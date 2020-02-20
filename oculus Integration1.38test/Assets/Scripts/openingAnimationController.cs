using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openingAnimationController : MonoBehaviour
{
    [SerializeField] private List<GameObject> cameras = new List<GameObject>();


    public static openingAnimationController instance = null;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void StartNextCamera()
    {
        if(cameras.Count > 0)
        {
            cameras[0].SetActive(true);
        }
        
    }

    public void DestroyCamera(GameObject camera)
    {
        cameras.RemoveAt(0);
        Destroy(camera);
        StartNextCamera();
    }

   
}
