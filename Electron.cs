using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electron : MonoBehaviour
{
    public float speedE = 4.0f;
    public bool col = false;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        col = false;
        GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (col)
        {
            transform.Translate(new Vector3(1, -1, 0) * speedE * Time.deltaTime);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wave"))
        {
            col = true;
        }
        other.transform.Translate(-2.2f, 0, 0);
        other.gameObject.transform.rotation = Quaternion.Euler(0, 180, -30);
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;


    }
}
