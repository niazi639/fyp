using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Animator DoorAnimator;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            DoorAnimator.SetBool("doorOpen", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag== "Player")
        {
            DoorAnimator.SetBool("doorOpen", false);
        }
    }
    

}
