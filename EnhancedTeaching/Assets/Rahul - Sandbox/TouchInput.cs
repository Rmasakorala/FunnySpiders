using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private bool isSelected;
    string selectedObjectName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        for (var i = 0; i < Input.touchCount; ++i)
        {
  
            if (Input.GetKeyDown ("1")) //debuging on PC
                {
                    this.transform.Rotate(0, 0, 5);
                }
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) //touch input
                {
                    Debug.Log("detecting Touch");
                    Ray ray = Camera.current.ScreenPointToRay(Input.GetTouch(0).position * 100);
                    Debug.DrawRay(ray.origin, ray.direction * 100, Color.green, 100f);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        this.transform.Rotate(0, 0, 5);
                        selectedObjectName = hit.transform.name;
                        if(selectedObjectName == this.name)
                        {

                        }
                        Debug.Log("selcted object is :" + selectedObjectName);

                    }
                }
        }
    }
}
