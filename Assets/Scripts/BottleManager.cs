using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleManager : MonoBehaviour
{
    public GameObject Bottle1, Bottle2, Bottle3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<10;i++)
        {
            var newpos = new Vector3(Random.Range(-8f, 88f), 25f, Random.Range(-4, 103f));
            Instantiate(Bottle1, newpos, Quaternion.identity);
            Instantiate(Bottle2, newpos, Quaternion.identity);
            Instantiate(Bottle3, newpos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
