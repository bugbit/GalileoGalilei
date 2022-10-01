using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrellaObj : MonoBehaviour
{
    public CosmoEscalaData escala;
    public GameObject model;

    private SolDataItem data;

    public void CalcDatas()
    {
        var radiusData =
            (data.equaRadius != 0)
                ? data.equaRadius
                : (data.meanRadius > 0)
                    ? data.meanRadius
                    : data.polarRadius;
        var radius = (float)escala.radio_estrella.Calc(radiusData);

        model.transform.localScale = new Vector3(radius, radius, radius);
    }

    // Start is called before the first frame update
    void Awake()
    {
        data = GetComponent<SolDataItem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("Aplicar Escala")]
    void AplicarEscala()
    {
        Awake();
        CalcDatas();
    }
}
