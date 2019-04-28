using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageDragAndDrop : Checker
{

    public GameObject OrigPos;
    public bool dropped;
    private Checker checker;
    void Start () {
        checker = GameObject.Find ("Checker").GetComponent<Checker>();
    }
    public void Drag ()
    {
        if (dropped == false)
        {
            // Store the position of the mouse and moves the object Image accordingly.
            transform.position = Input.mousePosition;
            print ("We are dragging the mouse");
        }

    }

    public void Drop ()
    {
            GameObject PlaceHolder = GameObject.Find ("Placeholder" + gameObject.tag);
            print (PlaceHolder);
            float distance = Vector3.Distance (transform.position, PlaceHolder.transform.position);
            print ("distance " + distance);
            if (distance < 70) {
                if (PlaceHolder.tag == gameObject.tag) {
                    transform.position = PlaceHolder.transform.position;
                    dropped = true;
                    checker.num -= 1;
                }
                else {
                    transform.position = OrigPos.transform.position;
                }
            }
            else {
                transform.position = OrigPos.transform.position;
            }
        
        

    }

}
