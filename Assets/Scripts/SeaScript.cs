using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaScript : MonoBehaviour
{
    public Renderer sea;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        sea = GetComponent<Renderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float offset =Time.time * speed;
        sea.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
