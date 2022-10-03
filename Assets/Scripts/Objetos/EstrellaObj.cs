using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AstroObj))]
public class EstrellaObj : MonoBehaviour
{
    public AstroObj astro;
    public GameObject model;

    public void ChangeMaterial(ETypeMaterials type)
    {
        astro.ChangeMaterial(type);
    }

    public void CalcDatas(CosmoEscalaData escala)
    {
        var data = astro.data;
        var radiusData =
            (data.equaRadius != 0)
                ? data.equaRadius
                : (data.meanRadius > 0)
                    ? data.meanRadius
                    : data.polarRadius;
        var radius = (float)escala.radio_estrella.Calc(radiusData);

        model.transform.localScale = new Vector3(radius, radius, radius);
    }

    void Start()
    {
        if (astro == null)
            astro = GetComponent<AstroObj>();
    }
}
