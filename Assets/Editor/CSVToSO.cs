using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class CSVToSO{
    private const string solDataPath="/Editor/sol_data.csv";

    [MenuItem("Utilities/GenerateSolData")]
    public static void GenerateSolData()
    {
        //System.Diagnostics.Debugger.Break();
        var data=File.ReadAllLines(Application.dataPath+solDataPath);
    }
}
