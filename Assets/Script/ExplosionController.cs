using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{

    public AnimationClip clip;

    private void OnEnable()
    {
        Invoke("OnDisable", clip.length);
    }
    private void OnDisable()
    {
            Destroy(gameObject);    
    }
}


