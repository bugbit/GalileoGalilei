using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CosmoEscalaData), typeof(SistemasObj))]
public class CelestialsObj : MonoBehaviour
{
    public CosmoEscalaData escala;
    public SistemasObj sistemas;

    public void ChangeMaterial(ETypeMaterials type)
    {
        sistemas.ChangeMaterial(type);
    }

    public void CalcDatas()
    {
        sistemas.CalcDatas(escala);
    }

    [ContextMenu("Aplicar Escala")]
    void AplicarEscala()
    {
        CalcDatas();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
