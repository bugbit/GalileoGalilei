using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialsData : MonoBehaviour
{
    public List<SistemaPlanetarioData> sistemas = new List<SistemaPlanetarioData>();

    public static CelestialsData instance;

    public SolDataItem GetItem(string name)
    {
        var obj = gameObject.transform.Find(name);
        var item = obj.GetComponent<SolDataItem>();

        return item;
    }

    private void Awake()
    {
        if (instance == null)
        {
            // Tell Unity not to destory the
            //  the GameObject this script component
            //  is attached to (thus keeping it alive
            //  as well).
            DontDestroyOnLoad(gameObject);

            // Save a reference to 'this'
            instance = this;
        }
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
