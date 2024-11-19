using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.Translate(Vector3.back  * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.T))
        {
                transform.Translate(Vector3.right  * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Y ))
        {
            transform.Translate(Vector3.left  * Time.deltaTime * speed);
        }

    }
}       
