using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemasObj : MonoBehaviour
{
    public List<SistemaPlanetarioObj> sistemas;

    public void CalcDatas(CosmoEscalaData escala)
    {
        sistemas.ForEach(s => s.CalcDatas(escala));
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
