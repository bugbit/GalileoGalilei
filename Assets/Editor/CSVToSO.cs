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

public class CSVToSO
{
    private const string solDataPath = "/Editor/sol_data.csv";

    [MenuItem("Utilities/GenerateSolData")]
    public static void GenerateSolData()
    {
        //System.Diagnostics.Debugger.Break();
        var lines = File.ReadAllLines(Application.dataPath + solDataPath);
        var data = lines.Select(l => l.Split(',')).ToArray();
        var type = typeof(SolData);
        var properties = data[0].Select(c => type.GetField(c)).ToArray();
        var pnull = properties.Where(p => p == null);
        //var lsolDatas = new List<SolData>();

        if (pnull.Any())
            if (properties.Any(p => p == null))
                throw new NullReferenceException(pnull.First().Name);

        foreach (var dl in data.Skip(1))
        {
            var solData = ScriptableObject.CreateInstance<SolData>();

            if (dl.Length > properties.Length)
                throw new InvalidOperationException("dl.Length > properties.Length");
            for (var i = 0; i < properties.Length; i++)
            {
                var value = dl[i];
                var p = properties[i];
                var t = p.FieldType;

                if (t == typeof(string))
                    p.SetValue(solData, value);
                else if (t == typeof(decimal))
                    p.SetValue(solData, Convert.ToDecimal(value));
                else if (t == typeof(double))
                    p.SetValue(solData, Convert.ToDouble(value, CultureInfo.InvariantCulture));
                else
                    throw new NotImplementedException($"convert from {t.Name}");
            }

            //lsolDatas.Add(solData);

            AssetDatabase.CreateAsset(solData, $"Assets/Data/SolData/{solData.eName}.asset");

            break;
        }

        //var solDatas = ScriptableObject.CreateInstance<SolDatas>();

        //solDatas.astros = lsolDatas;

        //AssetDatabase.CreateAsset(solDatas, $"Assets/Data/SolData.asset");

        AssetDatabase.SaveAssets();
    }
}
