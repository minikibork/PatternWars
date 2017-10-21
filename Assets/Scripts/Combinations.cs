using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combinations : MonoBehaviour {
    Dekk deck;
    List<int> l1 = new List<int>() {0, 0, 1, 2, 5 };
    List<int> l2 = new List<int>() {0, 0, 1, 2, 3 };
    List<int> l3 = new List<int>() {0, 0, 1, 2, 4 };
    List<int> l4 = new List<int>() { 1, 2, 4 };
    List<int> l5 = new List<int>() { 1, 2, 4 };
    List<int> l6 = new List<int>() { 1, 2, 4 };
    List<int> l7 = new List<int>() { 1, 2, 4 };
    List<int> l8 = new List<int>() { 1, 2, 4 };
    List<int> l9 = new List<int>() { 1, 2, 4 };
    List<int> l10 = new List<int>() { 1, 2, 4 };


    List<List<int>> l11 = new List<List<int>>();

    SelectedCards listOfSelectedCards;
    //List<hell   > hello2 = new List<List<>>();
    public List<GameObject> work = new List<GameObject>();
    // Use this for initialization
    public GameObject[] respawns;
    public bool isLegit = true;
    public int n = 0;
    void Start () {
        deck = GetComponent<Dekk>();
        //work = deck.cards;
        listOfSelectedCards = GetComponent<SelectedCards>();
        // respawns = GameObject.FindGameObjectsWithTag("Card");
        LegitCombination();
    }
    
    void FixedUpdate()
    {

    }
    void fillCombinationList()
    {
        l11.Add(l1);
        l11.Add(l2);
        l11.Add(l3);
    }
    void LegitCombination()
    {
        
        if (l11.Contains(l4))
        {
            Debug.Log(l1);
            Debug.Log(l11);
            Debug.Log("they are the same");
        }

        else
        {
            Debug.Log("they are not");
        }
        /*
        int i = 0;
        for(i = 0; i < 5; i++ )
        {

        if (l2.Contains(l1[i]))
        {
                Debug.Log("they are the same");
                n++;
                if(n==5)
                {
                    Debug.Log("its legit combination");
                }
        }
            else if (l3.Contains(l1[i]))
            {
                Debug.Log("they are the same");
                n++;
                if (n == 5)
                {
                    Debug.Log("its legit combination");
                }
            }

            else if (l4.Contains(l1[i]))
            {
                Debug.Log("they are the same");
                n++;
                if (n == 5)
                {
                    Debug.Log("its legit combination");
                }
            }

            else if (l5.Contains(l1[i]))
            {
                Debug.Log("they are the same");
                n++;
                if (n == 5)
                {
                    Debug.Log("its legit combination");
                }
            }


            /* else if(l3.Contains(l1[i]))
                 {
                     Debug.Log("they are the same");
                 }
                
    
            else
            {
                
                Debug.Log("they are not the same");
            }
        */
        }


    
    bool CheckMatch()
    {
        if (l1 == null && l2 == null)
        {
            return true;
        }
        else if (l1 == null || l2 == null)
        {
            return false;
        }

        if (l1.Count != l2.Count)
            return false;
        for (int i = 0; i < l1.Count; i++)
        {
            if (l1[i] != l2[i])
                return false;
        }
        return true;
    }

    

    void OptimalScore()
    {
        
    }

    void Combination2s()
    {

    }
    // Update is called once per frame
    
}
