using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmoEscalaData : MonoBehaviour
{
    public CosmoEscalaItemData radio_planeta;
    public CosmoEscalaItemData distancia;
    public CosmoEscalaItemData radio_estrella;

    public static CosmoEscalaData CreateEscalaVistaPlanetaria = new CosmoEscalaData
    {
        //{30.0, 11.2 * 12756.78 / 2.0},
        radio_planeta=new CosmoEscalaItemData        {            numerator=1,denominator=10000        },
        //{350.0, 590010000},
        distancia=new CosmoEscalaItemData        {numerator=1, denominator=1000000},
        //{90.0, 14950300},
        radio_estrella=new CosmoEscalaItemData {numerator= 1, denominator= 100000},
};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
