using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter_Ender : MonoBehaviour
{
    public Light light_End;
    public Color color;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            light_End.color = color;
        }
    }
}
