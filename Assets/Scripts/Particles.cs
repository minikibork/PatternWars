using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    [SerializeField]
    private int secondsBeforeDestroy = 2;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(ParticlesDestroy(gameObject));
    }
    
    IEnumerator ParticlesDestroy(GameObject particle)
    {

        yield return new WaitForSeconds(secondsBeforeDestroy);

        DestroyImmediate(particle);
    }
    
}
