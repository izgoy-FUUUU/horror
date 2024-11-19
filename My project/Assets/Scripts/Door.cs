using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform doorTransform;
    public Vector3 openRotation;
    public Vector3 closeRotation;
    public float doorSpeed = 20;
    public float distation = 3;

    private bool isOpen = false;

    private bool isInRange = false;

    private void Update()
    {
        if (Vector3.Distance(transform.position, Camera.main.transform.position )<distation)
        {
            isInRange = true;
            if (Input.GetKey(KeyCode.E))
            {
                isOpen = !isOpen;
            }
        }
        else
        {
            isInRange = false;
        }

        Quaternion targetRotation = Quaternion.Euler(isOpen ?openRotation:closeRotation);
        doorTransform.localRotation = Quaternion.Slerp(doorTransform.localRotation,targetRotation,Time.deltaTime*doorSpeed);
    }
    private void OnGUI()
    {
        if( isInRange == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 50, 200, 50), "Press E to Open/Close");
        }
    }
}




































































//// Start is called before the first frame update
//void Start()
//{

//}

//// Update is called once per frame
////void Update()
////{
////    if (Input.GetKey(KeyCode.F)) 
////    {
////        transform.Rotate(Vector3.up);
////    }
////}