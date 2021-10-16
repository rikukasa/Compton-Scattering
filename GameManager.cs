using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> act;
    public List<GameObject> inact;

    Electron electron;
    // Start is called before the first frame update
    void Start()
    {
        electron = GameObject.Find("Electron").GetComponent<Electron>();
    }

    // Update is called once per frame
    void Update()
    {
        if (electron.col)
        {
            foreach(GameObject g in act)
            {
                g.SetActive(true);
            }
            foreach(GameObject g in inact)
            {
                g.SetActive(false);
            }
        }
    }
}
