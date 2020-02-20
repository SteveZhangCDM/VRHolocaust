using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerEnd : MonoBehaviour
{

    public void OnAnimationEnd()
    {
        openingAnimationController.instance.DestroyCamera(gameObject);
    }
}
