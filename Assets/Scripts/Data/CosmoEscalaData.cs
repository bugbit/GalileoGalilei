using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmoEscalaData : MonoBehaviour
{
    //Make the private field of our PlayerStats struct visible in the Inspector
    //by applying [SerializeField] attribute to it
    [SerializeField]
    public CosmoEscalaItemData radio_planeta;
    //Make the private field of our PlayerStats struct visible in the Inspector
    //by applying [SerializeField] attribute to it
    [SerializeField]
    public CosmoEscalaItemData distancia;
    //Make the private field of our PlayerStats struct visible in the Inspector
    //by applying [SerializeField] attribute to it
    [SerializeField]
    public CosmoEscalaItemData radio_estrella;

    [ContextMenu("Aplicar EscalaVistaPlanetaria")]
    void AplicarEscalaVistaPlanetaria()
    {
        //{30.0, 11.2 * 12756.78 / 2.0},
        radio_planeta = new CosmoEscalaItemData
        {
            numerator = 1,
            denominator = 10000
        };
        //{350.0, 590010000},
        distancia = new CosmoEscalaItemData { numerator = 1, denominator = 1000000 };
        //{90.0, 14950300},
        radio_estrella = new CosmoEscalaItemData { numerator = 1, denominator = 100000 };
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
