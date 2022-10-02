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
        var obj = GameObject.FindGameObjectsWithTag("Celestials").FirstOrDefault(o => o.activeSelf);

        // if (obj!=null)
        // obj.GetComponent<CelestialsObj>().
    }
}
