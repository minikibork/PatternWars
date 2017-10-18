using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour {

    Dekk deck;

    

    void OnEnable()
    {
        EventManager.OnClick += Highlighting;
    }

    void OnDisable()
    {
        EventManager.OnClick -= Highlighting;
        
    }

    void Start()
    {
        deck = GetComponent<Dekk>();
    }
    void Highlighting()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.Log(hit.transform.gameObject.name);
            Debug.Log("i am working");
        }
        
        Debug.Log("I am clicked");
        //Change sprites with Highlighted ones
    }



}
