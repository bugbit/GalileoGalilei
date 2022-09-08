using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    

    [ContextMenu("Do Something")]
    void DoSomething()
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
