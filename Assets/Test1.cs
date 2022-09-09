using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public List<SolData> solData=new List<SolData>();

    [ContextMenu("Generate SolData")]
    void GenerateSolData()
    {
        Debug.Log("Perform operation");
    }

    // Start is called before the first frame update
    void Start()
    {
        //CSVToSO.GenerateSolData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
