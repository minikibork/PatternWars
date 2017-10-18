using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combinations : MonoBehaviour {
    Dekk deck;
    List<int> toInspect = new List<int>() { 1, 2, 3 };
    List<int> hello = new List<int>() { 1, 2, 4 };
   //List<hell   > hello2 = new List<List<>>();
    public List<GameObject> work = new List<GameObject>();
    // Use this for initialization
    public GameObject[] respawns;

    void OnEnable()
    {
        EventManager.OnClick += CheckedClick;
    }

    void OnDisable()
    {
        EventManager.OnClick -= CheckedClick;

    }
    
    void Start () {
        deck = GetComponent<Dekk>();
        //work = deck.cards;
       
        
        respawns = GameObject.FindGameObjectsWithTag("Card");
    }
    
    void Update()
    {
        
    }
            void CheckedClick()
    {

        
    }
    // Update is called once per frame
    
}
