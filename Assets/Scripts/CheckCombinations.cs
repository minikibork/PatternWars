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

[System.Serializable]
public struct OptimalCardList
{
    public int indexOcl;
    public int colorOcl;
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
  

    public GameObject sendButtonG;
    public GameObject deckFill;
    public CardInformation[] cardIndexSelected;
    public List<CardInformation> cardIndexesChildren;
    public Transform childTransform;
    public GameObject SendButtonPlease;
    
    public bool legitCombination = false;
    public int readyToDestroy = 0;
    public bool isLegitColors = false;
    public bool isThreeColors = false;
    
    void Start()
    {
        
        sendButton = sendButtonG.GetComponent<SendButton2>();
        //Debug.Log(cardIndexSelected);
        

    }
    void Update()
    {

        cardIndexSelected = deckFill.GetComponentsInChildren<CardInformation>();
        childTransform = gameObject.GetComponentInChildren<Transform>();
        CheckForValidLenght();
        LegitCombination();
        OptimalScore();
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

    void LegitColors()
    {
        if (listOfColors.Contains(1) && listOfColors.Contains(2) && listOfColors.Contains(3))
        {
            isThreeColors = true;
            isLegitColors = true;
            Debug.Log("THREE different colors");
        }

        else if (listOfColors.Contains(1) && listOfColors.Contains(2) == false && listOfColors.Contains(3) == false)
        {
            
            isLegitColors = true;
            Debug.Log("Same colors");
        }
        else if (listOfColors.Contains(2) && listOfColors.Contains(1) == false && listOfColors.Contains(3) == false)
        {
            isLegitColors = true;
            Debug.Log("Same colors");
        }
        else if (listOfColors.Contains(3) && listOfColors.Contains(1) == false && listOfColors.Contains(2) == false)
        {
            isLegitColors = true;
            Debug.Log("Same colors");
        }

        else
        {
            isLegitColors = false;
            Debug.Log("Not Legit colors");
            listOfIndexes.Clear();
            listOfColors.Clear();
            isThreeColors = false;
        }
    }

    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 

    void LegitOptinalCombinations()
    {



    }
    void LegitCombination()
    {
        if (sendButton.hasBeenSend == true)
        {
            LegitColors();
            if(isLegitColors == true)
            {
                Debug.Log("We are on");
     
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
                            Debug.Log("Not a valid combination");
                            break;

                        }
                    }

                    if (counter == listOfIndexes.Count)
                    {
                        TotalScore += cardCombinations[i].score;
                        Debug.Log("Valid Combination");
                            // Debug.Log(i);
                            // Debug.Log(TotalScore);
                            MatchOptimalScore();
                            legitCombination = true;
                            ReplaceAndDestroyCards();
                            break;

                    }
                    counter = 0;
                }
                 
            }
                listOfIndexes.Clear();
                listOfColors.Clear();
                isThreeColors = false;
                isLegitColors = false;
            }
        sendButton.hasBeenSend = false;
        }
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
    public List<int> list = new List<int>();
    public List<int> listOfAllIndexes = new List<int>();
    int c1=0, c2=0, c3=0, c4=0, c5=0, c6=0, c7=0;
    bool currentCombinations = false;

    public Component[] indexes;
    void OptimalScore()
    {
        
        deck = GetComponent<Dekk>();
        
        indexes = deckFill.GetComponentsInChildren<CardInformation>();
        foreach (CardInformation card in indexes)
        {    if(legitCombination == true)
            {
                listOfAllIndexes.Clear();
            }

            else if (deck.amountsOfCards != listOfAllIndexes.Count)
            {
                int n = card.cardIndex;
                listOfAllIndexes.Add(n);
                RepeatingIndexes(n);

            }

        }    
    }
    void RepeatingIndexes(int n)
    {
        if (n == 1)
        {
            c1++;
        }
        else if (n == 2)
        {
            c2++;
        }
        else if (n == 3)
        {
            c3++;
        }
        else if (n == 4)
        {
            c4++;
        }
        else if (n == 5)
        {
            c5++;
        }
        else if (n == 6)
        {
            c6++;
        }
        else if (n == 7)
        {
            c7++;
        }
    }

    void MatchOptimalScore()
    {
        if (listOfAllIndexes.Contains(1) && listOfAllIndexes.Contains(2) && listOfAllIndexes.Contains(3) && listOfAllIndexes.Contains(4) && listOfAllIndexes.Contains(7))
        {
            Debug.Log("5 star is the highest");
            currentCombinations = true;
            return;
        }

        else if (listOfAllIndexes.Contains(1) && c1 == 5)
        {
            Debug.Log("11111");
            currentCombinations = true;
            return;
        }

        else if (listOfAllIndexes.Contains(2) && c2 == 5)
        {
            Debug.Log("22222");
            currentCombinations = true;
            return;
        }

        else if (listOfAllIndexes.Contains(3) && c3 == 5)
        {
            Debug.Log("33333");

            currentCombinations = true;
            return;
        }

        else if (listOfAllIndexes.Contains(4) && c4 == 5)
        {
            Debug.Log("44444");

            currentCombinations = true;
            return;
        }

        else if (listOfAllIndexes.Contains(5) && c5 == 5)
        {
            Debug.Log("55555");
            currentCombinations = true;
            return;
        }
        else if (listOfAllIndexes.Contains(6) && c6 == 5)
        {
            Debug.Log("66666");
            currentCombinations = true;
            return;
        }
        else if (listOfAllIndexes.Contains(7) && c7 == 5)
        {
            Debug.Log("77777");
            currentCombinations = true;
            return;
        }
        else if (listOfAllIndexes.Contains(5) && listOfAllIndexes.Contains(6) && listOfAllIndexes.Contains(7))
        {
            Debug.Log("5 6 7");
            currentCombinations = true;
            return;
        }
        else if (listOfAllIndexes.Contains(3) && listOfAllIndexes.Contains(4) && listOfAllIndexes.Contains(6) && listOfAllIndexes.Contains(7))
        {
            Debug.Log("3 4 6 7");
            currentCombinations = true;
            return;
        }
        else if (listOfAllIndexes.Contains(1) && listOfAllIndexes.Contains(2) && listOfAllIndexes.Contains(5) && listOfAllIndexes.Contains(7))
        {
            Debug.Log("1 2 5 7");
            currentCombinations = true;
            return;
        }
        else if (listOfAllIndexes.Contains(1) && listOfAllIndexes.Contains(2) && listOfAllIndexes.Contains(6))
        {
            Debug.Log("1 2 6");
            currentCombinations = true;
            return;
        }
        else if (listOfAllIndexes.Contains(3) && listOfAllIndexes.Contains(4) && listOfAllIndexes.Contains(5))
        {
            Debug.Log("3 4 5");
            currentCombinations = true;
            return;
        }
        else if (listOfAllIndexes.Contains(1) && c1 == 4)
        {
            Debug.Log("1111");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(2) && c2 == 4)
        {
            Debug.Log("2222");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(3) && c3 == 4)
        {
            Debug.Log("3333");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(4) && c4 == 4)
        {
            Debug.Log("4444");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(5) && c5 == 4)
        {
            Debug.Log("5555");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(6) && c6 == 4)
        {
            Debug.Log("6666");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(7) && c7 == 4)
        {
            Debug.Log("7777");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(1) && c1 == 3)
        {
            Debug.Log("111");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(2) && c2 == 3)
        {
            Debug.Log("222");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(3) && c3 == 3)
        {
            Debug.Log("333");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(4) && c4 == 3)
        {
            Debug.Log("444");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(5) && c5 == 3)
        {
            Debug.Log("555");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(6) && c6 == 3)
        {
            Debug.Log("666");
            currentCombinations = true;
            return;
        }
        if (listOfAllIndexes.Contains(7) && c7 == 3)
        {
            Debug.Log("777");
            currentCombinations = true;
            return;
        }
        else
        {
            Debug.Log("No more combinations");
            currentCombinations = false;
        }
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
/*
if(listOfAllIndexes.Contains(1) && c1==3)
        {
            Debug.Log("111");
            
        }
        if (listOfAllIndexes.Contains(1) && c1 == 4)
        {
            Debug.Log("1111");
        }
        if (listOfAllIndexes.Contains(1) && c1 == 5)
        {
            Debug.Log("11111");
        }
        if (listOfAllIndexes.Contains(2) && c2 == 3)
        {
            Debug.Log("222");
        }
        if (listOfAllIndexes.Contains(2) && c2 == 4)
        {
            Debug.Log("2222");
        }
        if (listOfAllIndexes.Contains(2) && c2 == 5)
        {
            Debug.Log("22222");

        }
        if (listOfAllIndexes.Contains(3) && c3 == 3)
        {
            Debug.Log("333");
        }
        if (listOfAllIndexes.Contains(3) && c3 == 4)
        {
            Debug.Log("3333");
        }
        if (listOfAllIndexes.Contains(3) && c3 == 5)
        {
            Debug.Log("33333");
        }
        if (listOfAllIndexes.Contains(4) && c4 == 3)
        {
            Debug.Log("444");
        }
        if (listOfAllIndexes.Contains(4) && c4 == 4)
        {
            Debug.Log("4444");
        }
        if (listOfAllIndexes.Contains(4) && c4 == 5)
        {
            Debug.Log("44444");
        }
        if (listOfAllIndexes.Contains(5) && c5 == 3)
        {
            Debug.Log("555");
        }
        if (listOfAllIndexes.Contains(5) && c5 == 4)
        {
            Debug.Log("5555");
        }
        if (listOfAllIndexes.Contains(5) && c5 == 5)
        {
            Debug.Log("55555");
        }
        if (listOfAllIndexes.Contains(6) && c6 == 3)
        {
            Debug.Log("666");
        }
        if (listOfAllIndexes.Contains(6) && c6 == 4)
        {
            Debug.Log("6666");
        }
        if (listOfAllIndexes.Contains(6) && c6 == 5)
        {
            Debug.Log("66666");
        }
        if (listOfAllIndexes.Contains(7) && c7 == 3)
        {
            Debug.Log("777");
        }
        if (listOfAllIndexes.Contains(7) && c7 == 4)
        {
            Debug.Log("7777");
        }
        if (listOfAllIndexes.Contains(7) && c7 == 5)
        {
            Debug.Log("77777");
        }
*/
/*
    if (listOfAllIndexes.Contains(1) && listOfAllIndexes.Contains(2) && listOfAllIndexes.Contains(3) && listOfAllIndexes.Contains(4) && listOfAllIndexes.Contains(7))
        {
            Debug.Log("5 star is the highest");

        }

        else if (listOfAllIndexes.Contains(1) && c1 == 5)
        {
            Debug.Log("11111");
        }

        else if (listOfAllIndexes.Contains(2) && c2 == 5)
        {
            Debug.Log("22222");
        }

        else if (listOfAllIndexes.Contains(3) && c3 == 5)
        {
            Debug.Log("33333");
        }

        else if (listOfAllIndexes.Contains(4) && c4 == 5)
        {
            Debug.Log("44444");
        }

        else if (listOfAllIndexes.Contains(5) && c5 == 5)
        {
            Debug.Log("55555");
        }
        else if (listOfAllIndexes.Contains(6) && c6 == 5)
        {
            Debug.Log("66666");
        }
        else if (listOfAllIndexes.Contains(7) && c7 == 5)
        {
            Debug.Log("77777");
        }
        else if (listOfAllIndexes.Contains(5) && listOfAllIndexes.Contains(6) && listOfAllIndexes.Contains(7))
        {
            Debug.Log("5 6 7");
        }
        else if (listOfAllIndexes.Contains(3) && listOfAllIndexes.Contains(4) && listOfAllIndexes.Contains(6) && listOfAllIndexes.Contains(7))
        {
            Debug.Log("3 4 6 7");
        }
        else if (listOfAllIndexes.Contains(1) && listOfAllIndexes.Contains(2) && listOfAllIndexes.Contains(5) && listOfAllIndexes.Contains(7))
        {
            Debug.Log("1 2 5 7");
        }
        else if (listOfAllIndexes.Contains(1) && listOfAllIndexes.Contains(2) && listOfAllIndexes.Contains(6))
        {
            Debug.Log("1 2 6");
        }
        else if (listOfAllIndexes.Contains(3) && listOfAllIndexes.Contains(4) && listOfAllIndexes.Contains(5))
        {
            Debug.Log("3 4 5");
        }
        else if (listOfAllIndexes.Contains(1) && c1 == 4)
        {
            Debug.Log("1111");
        }
        if (listOfAllIndexes.Contains(2) && c2 == 4)
        {
            Debug.Log("2222");
        }
        if (listOfAllIndexes.Contains(3) && c3 == 4)
        {
            Debug.Log("3333");
        }
        if (listOfAllIndexes.Contains(4) && c4 == 4)
        {
            Debug.Log("4444");
        }
        if (listOfAllIndexes.Contains(5) && c5 == 4)
        {
            Debug.Log("5555");
        }
        if (listOfAllIndexes.Contains(6) && c6 == 4)
        {
            Debug.Log("6666");
        }
        if (listOfAllIndexes.Contains(7) && c7 == 4)
        {
            Debug.Log("7777");
        }
        if (listOfAllIndexes.Contains(1) && c1 == 3)
        {
            Debug.Log("111");
        }
        if (listOfAllIndexes.Contains(2) && c2 == 3)
        {
            Debug.Log("222");
        }
        if (listOfAllIndexes.Contains(3) && c3 == 3)
        {
            Debug.Log("333");
        }
        if (listOfAllIndexes.Contains(4) && c4 == 3)
        {
            Debug.Log("444");
        }
        if (listOfAllIndexes.Contains(5) && c5 == 3)
        {
            Debug.Log("555");
        }
        if (listOfAllIndexes.Contains(6) && c6 == 3)
        {
            Debug.Log("666");
        }
        if (listOfAllIndexes.Contains(7) && c7 == 3)
        {
            Debug.Log("777");
        }
        */
