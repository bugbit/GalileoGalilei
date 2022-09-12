using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolDataItemObj : MonoBehaviour
{
    public string name;
    public SolDataItem data;

    // Start is called before the first frame update
    void Start()
    {
        if (string.IsNullOrEmpty(name))
            name = gameObject.name;
        if (data == null)
            data = CelestialsData.instance.GetItem(name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
