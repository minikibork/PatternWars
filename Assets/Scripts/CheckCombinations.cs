using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[System.Serializable]
public struct cardLists
{
    public List<int> combination;
    public int score;
}

public class CheckCombinations : MonoBehaviour, IPointerDownHandler
{
    Dekk deck;
    public int TotalScore;


    [SerializeField]
    public List<cardLists> cardCombinations;

    public List<int> listOfColors = new List<int>();
    public List<int> listOfIndexes = new List<int>();
    private int counter;
    public bool isLegit = false;

    public List<Vector3> listOfVec3 = new List<Vector3>();
    public List<GameObject> listOfTargetsToDestroy = new List<GameObject>();


    private SendButton2 sendButton;
    public GameObject DeckFill;

    public GameObject sendButtonG;
    public GameObject deckFill;
    public CardInformation cardIndexSelected;
    public Transform childTransform;
    public GameObject SendButtonPlease;
    public bool legitCombination = false;
    public int readyToDestroy = 0;
    void Start()
    {
        sendButton = sendButtonG.GetComponent<SendButton2>();
    }
    void Update()
    {
        cardIndexSelected = gameObject.GetComponentInChildren<CardInformation>();
        childTransform = gameObject.GetComponentInChildren<Transform>();
        CheckForValidLenght();
        LegitCombination();
    }
   
   
    void CheckForValidLenght()
    {
        if (listOfIndexes.Count < 3)
        {
            SendButtonPlease.SetActive(false);

        }
        else
        {

            SendButtonPlease.SetActive(true);
        }
    }
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        
    }
    

    void LegitCombination()
    {
        if (sendButton.hasBeenSend == true)
        {
            Debug.Log("We are on");
        DeckFill = GameObject.FindGameObjectWithTag("Deck");
        //sendButton = sendButtonG.GetComponent<SendButton>();
        // myList = sendButton.selectedCardsSent;
        //Debug.Log(sendButton.selectedCardsSent);
       
        listOfIndexes.Sort();
        
        for (int i = 0; cardCombinations.Count - 1 > i; i++)
        {
            cardCombinations[i].combination.Sort();//sort all combinations
        }


        for (int i = 0; i < cardCombinations.Count - 1; i++)
        {
            counter = 0;

                if (cardCombinations[i].combination.Count == listOfIndexes.Count)
                {
                    for (int b = 0; b < cardCombinations[i].combination.Count; b++)
                    {
                        if (cardCombinations[i].combination[b] == listOfIndexes[b])
                        {
                            counter++;
                        }
                        else
                        {
                            //Debug.Log("Not a valid combination");
                            break;

                        }
                    }

                    if (counter == listOfIndexes.Count)
                    {
                        TotalScore += cardCombinations[i].score;
                        Debug.Log("Valid Combination");
                       // Debug.Log(i);
                       // Debug.Log(TotalScore);
                        legitCombination = true;
                        ReplaceAndDestroyCards();
                        break;

                    }
                    counter = 0;

                    
                }
                 
            }
            listOfIndexes.Clear();
            Debug.Log("koga sum az");
        }
        sendButton.hasBeenSend = false;
      
    }

    void ReplaceAndDestroyCards()
    {
        for(int i=0; i < listOfVec3.Count; i++)
        {
            deckFill = GameObject.FindGameObjectWithTag("Deck");
            deck = deckFill.GetComponent<Dekk>();
            int n = Random.Range(0, deck.cards.Count);
            GameObject g = Instantiate(deck.cards[n], listOfVec3[i], Quaternion.identity) as GameObject;
            deck.cards.Remove(deck.cards[n]);
            
            Destroy(listOfTargetsToDestroy[i]);
          
        }
        listOfTargetsToDestroy.Clear();
        listOfVec3.Clear();
    }

    /*
    public int n;

    public Vector3[] selectedCardTransforms;
    public EventManager eventy;
    void ReplaceAndDestroyCards() //TO BE FINISHED AFTER COMBINATIONS
    {
        if (legitCombination == true)
        {
            selectedCardTransforms =  
               eventy = GetComponent<EventManager>();
            childTransform = transform.position;

            //Debug.Log(selectedCardTransform);
            n++;
            GameObject g = Instantiate(deck.cards[n], childTransform, Quaternion.identity) as GameObject;
            Debug.Log(deck.cards[n]);
        }
        legitCombination = false;
    }
    */
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
