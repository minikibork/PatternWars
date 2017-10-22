using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combinations : MonoBehaviour {
    Dekk deck;
    List<int> l1 = new List<int>() {0, 0, 1, 2, 5 };
    List<int> l2 = new List<int>() {0, 0, 1, 2, 6 };
    List<int> l3 = new List<int>() {0, 0, 3, 4, 5 };
    List<int> l4 = new List<int>() {1, 2, 3, 4, 7 };
    List<int> l5 = new List<int>() { 0, 0, 5, 6, 7 };
    List<int> l6 = new List<int>() { 0, 1, 2, 5, 7 };
    List<int> l7 = new List<int>() { 0, 3, 4, 6, 7 };
    List<int> l8 = new List<int>() { 0, 0, 1, 1, 1 };
    List<int> l9 = new List<int>() { 0, 1, 1, 1, 1 };
    List<int> l10 = new List<int>() { 1, 1, 1, 1, 1 };
    List<int> l11 = new List<int>() { 0, 0, 2, 2, 2 };
    List<int> l12 = new List<int>() { 0, 2, 2, 2, 2 };
    List<int> l13 = new List<int>() { 2, 2, 2, 2, 2 };
    List<int> l14 = new List<int>() { 0, 0, 3, 3, 3 };
    List<int> l15 = new List<int>() { 0, 3, 3, 3, 3 };
    List<int> l16 = new List<int>() { 3, 3, 3, 3, 3 };
    List<int> l17 = new List<int>() { 0, 0, 4, 4, 4 };
    List<int> l18 = new List<int>() { 0, 4, 4, 4, 4 };
    List<int> l19 = new List<int>() { 4, 4, 4, 4, 4 };
    List<int> l20 = new List<int>() { 0, 0, 5, 5, 5 };
    List<int> l21 = new List<int>() { 0, 5, 5, 5, 5 };
    List<int> l22 = new List<int>() { 5, 5, 5, 5, 5 };
    List<int> l23 = new List<int>() { 0, 0, 6, 6, 6 };
    List<int> l24 = new List<int>() { 0, 6, 6, 6, 6 };
    List<int> l25 = new List<int>() { 6, 6, 6, 6, 6 };
    List<int> l26 = new List<int>() { 0, 0, 7, 7, 7 };
    List<int> l27 = new List<int>() { 0, 7, 7, 7, 7 };
    List<int> l28 = new List<int>() { 7, 7, 7, 7, 7 };
    List<int> l29 = new List<int>() { 0, 0, 8, 8, 8 };
    List<int> l30 = new List<int>() { 0, 8, 8, 8, 8 };
    List<int> l31 = new List<int>() { 8, 8, 8, 8, 8 };
    List<int> l32 = new List<int>() { 0, 0, 9, 9, 9 };
    List<int> l33 = new List<int>() { 0, 9, 9, 9, 9 };
    List<int> l34 = new List<int>() { 9, 9, 9, 9, 9 };

    public List<List<int>> listOfCombinations = new List<List<int>>();

    SelectedCards listOfSelectedCards;
    //List<hell   > hello2 = new List<List<>>();
    public List<GameObject> work = new List<GameObject>();
    // Use this for initialization
    public GameObject[] respawns;
    public bool isLegit = true;
    public int n = 0;
    void Start () {
        fillCombinationList();
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
        //listOfCombinations.Add(l1);
        listOfCombinations.Add(l2);
        listOfCombinations.Add(l3);
        listOfCombinations.Add(l4);
        listOfCombinations.Add(l5);
        listOfCombinations.Add(l6);
        listOfCombinations.Add(l7);
        listOfCombinations.Add(l8);
        listOfCombinations.Add(l9);
        listOfCombinations.Add(l10);
        listOfCombinations.Add(l11);
        listOfCombinations.Add(l12);
        listOfCombinations.Add(l13);
        listOfCombinations.Add(l14);
        listOfCombinations.Add(l15);
        listOfCombinations.Add(l16);
        listOfCombinations.Add(l17);
        listOfCombinations.Add(l18);
        listOfCombinations.Add(l19);
        listOfCombinations.Add(l20);
        listOfCombinations.Add(l21);
        listOfCombinations.Add(l22);
        listOfCombinations.Add(l23);
        listOfCombinations.Add(l24);
        listOfCombinations.Add(l25);
        listOfCombinations.Add(l26);
        listOfCombinations.Add(l27);
        listOfCombinations.Add(l28);
        listOfCombinations.Add(l29);
        listOfCombinations.Add(l30);
        listOfCombinations.Add(l31);
        listOfCombinations.Add(l32);
        listOfCombinations.Add(l33);
        listOfCombinations.Add(l34);

    }
    void LegitCombination()
    {
        for (int i = 0; i < listOfCombinations.Count; i++)
            
        if (listOfCombinations.Contains(l4))
        {
            
           // Debug.Log(l11);
           // Debug.Log("they are the same");
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
