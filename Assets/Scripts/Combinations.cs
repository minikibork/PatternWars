using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combinations : MonoBehaviour {
    Dekk deck;
    List<int> toInspect = new List<int>() { 1, 2, 3 };
    List<int> hello = new List<int>() { 1, 2, 4 };
    SelectedCards listOfSelectedCards;
    //List<hell   > hello2 = new List<List<>>();
    public List<GameObject> work = new List<GameObject>();
    // Use this for initialization
    public GameObject[] respawns;
    public bool isLegit = true;
    void Start () {
        deck = GetComponent<Dekk>();
        //work = deck.cards;
        listOfSelectedCards = GetComponent<SelectedCards>();
       // respawns = GameObject.FindGameObjectsWithTag("Card");
    }
    
    void Update()
    {
        
    }
            void LegitCombination()
    {

        
    }

    void Combination2s()
    {

    }
    // Update is called once per frame
    
}
