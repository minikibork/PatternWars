using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour {


    

    void OnEnable()
    {
        EventManager.OnClick += Highlighting;
    }

    void OnDisable()
    {
        EventManager.OnClick -= Highlighting;
        
    }

    void Highlighting()
    {
        Debug.Log("I am clicked");
    }



}
