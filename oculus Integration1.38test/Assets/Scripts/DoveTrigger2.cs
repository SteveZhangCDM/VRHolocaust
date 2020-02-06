using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoveTrigger2 : MonoBehaviour
{
    public Animator anima;

    private void OnTriggerEnter(Collider target)
    {
        if (target.name == "GrabVolumeBig")
        {
            Debug.Log("Hit");
            anima.Play("Dove#2");
        }
    }
}
