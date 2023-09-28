using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("MY_OBJECTS");
        for (int i = 0; i < objects.Length; i++)
        {
            Debug.Log(objects[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("HOLA!");
    }

    void OnCollisionEnter()
    {
        Debug.Log("Ouch!");
    }

}
