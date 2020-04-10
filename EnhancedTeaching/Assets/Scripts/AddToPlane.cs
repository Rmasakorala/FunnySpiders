using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToPlane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject plane = GameObject.FindGameObjectWithTag("Plane");
        transform.SetParent(plane.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
