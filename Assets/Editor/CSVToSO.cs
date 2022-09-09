using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using System.Linq;
using Codice.CM.Client.Differences.Graphic;
using System;
using System.Globalization;
using NUnit.Framework;
using Unity.VisualScripting;

public class CSVToSO
{
    private const string solDataPath = "/Editor/sol_data.csv";

    [MenuItem("Utilities/GenerateSolData")]
    public static void GenerateSolData()
    {
        var lines = File.ReadAllLines(Application.dataPath + solDataPath);
        var data = lines.Select(l => l.Split(',')).ToArray();
        var type = typeof(SolDataItem);
        var properties = data[0].Select(c => type.GetField(c)).ToArray();
        var pnull = properties.Where(p => p == null);
        var solDataObj = new GameObject { name = "CelestialsData" };

        try
        {
            var objs = new SortedList<string, GameObject>();
            GameObject sun = null;
            var planetas = new List<GameObject>();

            if (pnull.Any())
                if (properties.Any(p => p == null))
                    throw new NullReferenceException(pnull.First().Name);

            foreach (var dl in data.Skip(1))
            {
                //var solData = ScriptableObject.CreateInstance<SolData>();
                var obj = new GameObject();
                var solData = obj.AddComponent<SolDataItem>();

                if (dl.Length > properties.Length)
                    throw new InvalidOperationException("dl.Length > properties.Length");
                for (var i = 0; i < properties.Length; i++)
                {
                    var value = dl[i];

                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        var p = properties[i];
                        var t = p.FieldType;

                        if (t == typeof(string))
                            p.SetValue(solData, value);
                        else if (t == typeof(decimal))
                            p.SetValue(solData, Convert.ToDecimal(value));
                        else if (t == typeof(double))
                            p.SetValue(solData, Convert.ToDouble(value, CultureInfo.InvariantCulture));
                        else if (t == typeof(bool))
                            p.SetValue(solData, Convert.ToBoolean(value));
                        else
                            throw new NotImplementedException($"convert from {t.Name}");
                    }
                }

                obj.name = solData.eName;
                //obj.transform.parent = solDataObj.transform;
                objs.Add(obj.name, obj);

                if (obj.name == "Sun")
                    sun = obj;

                if (solData.isPlanet)
                    planetas.Add(obj);

                //lsolDatas.Add(solData);

                //AssetDatabase.CreateAsset(solData, $"Assets/Data/SolData/{solData.eName}.asset");
            }

            if (sun == null)
                throw new Exception("sun no in sol_data");

            var ssolar = new GameObject { name = "solarSystem" };
            var ssolardata = ssolar.AddComponent<SistemaPlanetarioData>();

            objs.Add(ssolar.name, ssolar);

            var celestialData = solDataObj.AddComponent<CelestialsData>();

            celestialData.sistemas.Add(ssolardata);

            var estrelladata = sun.AddComponent<EstrellaData>();

            ssolardata.Add(estrelladata);

            foreach (var planeta in planetas)
            {
                var planetadata = planeta.AddComponent<PlanetaData>();

                ssolardata.Add(planetadata);
            }

            foreach (var obj in objs)
                obj.Value.transform.parent = solDataObj.transform;

            // Create folder Prefabs and set the path as within the Prefabs folder,
            // and name it as the GameObject's name with the .Prefab format
            if (!Directory.Exists("Assets/Prefabs"))
                AssetDatabase.CreateFolder("Assets", "Prefabs");

            var localPath = "Assets/Prefabs/" + solDataObj.name + ".prefab";

            // Make sure the file name is unique, in case an existing Prefab has the same name.
            localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);

            if (File.Exists(localPath))
                AssetDatabase.DeleteAsset(localPath);

            PrefabUtility.SaveAsPrefabAsset(solDataObj, localPath);

            //var solDatas = ScriptableObject.CreateInstance<SolDatas>();

            //solDatas.astros = lsolDatas;

            //AssetDatabase.CreateAsset(solDatas, $"Assets/Data/SolData.asset");

            AssetDatabase.SaveAssets();
        }
        finally
        {
            GameObject.DestroyImmediate(solDataObj, false);
        }
    }
}
