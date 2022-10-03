using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SettingsApp : MonoBehaviour
{
    public static SettingsApp instance { get; protected set; }

    [SerializeField]
    private ETypeMaterials typeMaterial;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);

            throw new System.Exception("An instance of this singleton already exists.");
        }
        else
        {
            instance = this;
        }
    }

    void OnValidate()
    {
        //var objs = GameObject.FindGameObjectsWithTag("Celestials");
        var objs = GameObject.FindObjectsOfType<CelestialsObj>();

        foreach (var o in objs)
            o.ChangeMaterial(typeMaterial);

        // if (obj!=null)
        // obj.GetComponent<CelestialsObj>().
    }
}
