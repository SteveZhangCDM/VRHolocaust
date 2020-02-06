using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerForScene2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider target)
    {
        if (target.name == "GrabVolumeBig")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
