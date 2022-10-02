using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SolDataItem), typeof(MaterialsTypes))]
public class AstroObj : MonoBehaviour
{
    public SolDataItem data;
    public MaterialsTypes materials;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        if (data == null)
            data = GetComponent<SolDataItem>();
        if (materials == null)
            materials = GetComponent<MaterialsTypes>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
