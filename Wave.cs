using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public float speed = 4.0f;
    Electron electron;
    public Material red;
    public Material yellow;
    // Start is called before the first frame update
    void Start()
    {
        electron = GameObject.Find("Electron").GetComponent<Electron>();
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
