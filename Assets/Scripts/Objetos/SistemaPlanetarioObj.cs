using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPlanetarioObj : MonoBehaviour
{
    public List<EstrellaObj> estrellas;

    public void ChangeMaterial(ETypeMaterials type)
    {
        estrellas.ForEach(e => e.ChangeMaterial(type));
    }

    public void CalcDatas(CosmoEscalaData escala)
    {
        estrellas.ForEach(e => e.CalcDatas(escala));
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
