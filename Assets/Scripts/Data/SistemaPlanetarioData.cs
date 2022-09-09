using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPlanetarioData : MonoBehaviour
{
    public List<EstrellaData> estrellas = new List<EstrellaData>();
    public List<PlanetaData> planetas=new List<PlanetaData>();

    public void Add(EstrellaData data)
    {
        estrellas.Add(data);
        data.sistema = this;
    }

    public void Add(PlanetaData data)
    {
        planetas.Add(data);
        data.sistema = this;
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
