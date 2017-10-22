using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
[System.Serializable]
public struct cardLists
{
    public List<int> combination;
    public int score;
}
*/
public class Combinations : MonoBehaviour {
    Dekk deck;
    public int TotalScore;


    [SerializeField]
    public List<cardLists> cardCombinations;

    [SerializeField]
    private List<int> myList;

    private int counter;
    public bool isLegit = false;

    [SerializeField]
    private SelectedCards selectedCards;
        
    private SendButton sendButton;

    
    public GameObject sendButtonG;

    void Start () {
        
    }
    void Update()
    {
        //LegitCombination();
    }

    void OnEnable()
    {
        SendButton.Sent += LegitCombination;
    }


    void OnDisable()
    {
        SendButton.Sent -= LegitCombination;
    }

    void CheckIfSend()
    {
       
        sendButton = sendButtonG.GetComponent<SendButton>();
      
        if(sendButton.hasBeenSend == true)
        {

            //LegitCombination();
            Debug.Log("in the iff");
        }
        sendButton.hasBeenSend = false;
    }
  
    void LegitCombination()
    {
        sendButton = sendButtonG.GetComponent<SendButton>();
        myList = sendButton.selectedCardsSent;
        Debug.Log(sendButton.selectedCardsSent);
        //selectedCards = GetComponent<SelectedCards>();
       // myList = selectedCards.selectedCards;
        //myList.Sort();
        
        for (int i = 0; cardCombinations.Count - 1 > i; i++)
        {
            cardCombinations[i].combination.Sort();//sort all combinations
        }


        for (int i = 0; i < cardCombinations.Count - 1; i++)
        {
            counter = 0;

            if (cardCombinations[i].combination.Count == myList.Count)
            {
                for (int b = 0; b < cardCombinations[i].combination.Count; b++)
                {
                    if (cardCombinations[i].combination[b] == myList[b])
                    {
                        counter++;
                    }
                    else
                    {
                        Debug.Log("Not a valid combination");
                        break;
                    }
                }
                if (counter == myList.Count)
                {
                    TotalScore += cardCombinations[i].score;
                    Debug.Log(i);
                    Debug.Log(TotalScore);
                    break;
                    
                }
                counter = 0;
                selectedCards.selectedCards.Clear();
            }
        }
    }
    

    void OptimalScore()
    {
        
    }
    
  
}
/*
void LegitCombination()
{
    selectedCards = GetComponent<SelectedCards>();
    myList = selectedCards.selectedCards;
    myList.Sort();

    for (int i = 0; cardCombinations.Count - 1 > i; i++)
    {
        cardCombinations[i].combination.Sort();//sort all combinations
    }


    for (int i = 0; i < cardCombinations.Count - 1; i++)
    {
        counter = 0;

        if (cardCombinations[i].combination.Count == myList.Count)
        {
            for (int b = 0; b < cardCombinations[i].combination.Count; b++)
            {
                if (cardCombinations[i].combination[b] == myList[b])
                {
                    counter++;
                }
                else
                {
                    Debug.Log("Not a valid combination");
                    break;
                }
            }
            if (counter == myList.Count)
            {
                TotalScore += cardCombinations[i].score;
                Debug.Log(i);
                Debug.Log(TotalScore);
                break;

            }
            counter = 0;
            selectedCards.selectedCards.Clear();
        }
    }
}
*/
/*
   List<int> l1 = new List<int>() { 0, 0, 1, 2, 6 };
   List<List<int>> l36 = new List<List<int>> ();
   List<int> l2 = new List<int>() { 0, 0, 1, 2, 6 };
   List<int> l3 = new List<int>() { 0, 0, 3, 4, 5 };
   List<int> l4 = new List<int>() { 1, 2, 3, 4, 7 };
   List<int> l5 = new List<int>() { 0, 0, 5, 6, 7 };
   List<int> l6 = new List<int>() { 0, 1, 2, 5, 7 };
   List<int> l7 = new List<int>() { 0, 3, 4, 6, 7 };
   List<int> l8 =  new List<int>() { 0, 0, 1, 1, 1 };
   List<int> l9 =  new List<int>() { 0, 1, 1, 1, 1 };
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

   public List<List<int>> listOfCombinations = new List<List<int>>();
   */

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
