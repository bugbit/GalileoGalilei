using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefs : MonoBehaviour
{
    public static Prefs instance { get; protected set; }

    public ETypeMaterials typeMaterial;

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
}
