using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentDetail : MonoBehaviour
{
    public GameObject InformationPlane;

    private bool InfoAction = false;

    public void Start()
    {
        InformationPlane.SetActive(InfoAction);
        Debug.Log("Set False");
    }

    void Update()
    {
        // -------- Touch Student show information

        //if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        //    RaycastHit Hit;
        //    if (Physics.Raycast(ray, out Hit))
        //    {
        //        if (InfoAction == false)
                  //    InfoAction = true;
                  //else
                  //  InfoAction = false;

                  //InformationPlane.SetActive(InfoAction);
        //    }
        //}

        // ------- Mouse Click Student show information
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                if (InfoAction == false)
                    InfoAction = true;   
                else
                    InfoAction = false;

                InformationPlane.SetActive(InfoAction);
            }
        }
    }
}
