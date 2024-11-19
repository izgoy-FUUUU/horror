using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrimer : MonoBehaviour
{
    public   GameObject icecrimer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            icecrimer.SetActive(true);
        }
    }
}
