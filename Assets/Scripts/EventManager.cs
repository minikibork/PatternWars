
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class EventManager : MonoBehaviour, IPointerDownHandler
{
    public List<GameObject> cards = new List<GameObject>();
    
    public GameObject deckFill;
    public CheckCombinations listOfCards;
    public CardInformation cardIndexToAdd;
    public bool isSelected;
    public bool isLegitCombination;
    public Vector3 selectedCardTransform;
    public Vector3[] selectedCardTransforms;
    public GameObject lastPressed;
    public Dekk deck;
    GameObject decky;
    public GameObject self;
    public int n;
    int i = 0;
    public static int cardsDestroy = 0;
    void Start()
    {
        deckFill = GameObject.FindGameObjectWithTag("Deck");
        listOfCards = deckFill.GetComponent<CheckCombinations>();
        
        isSelected = false;
        
    }
    void Update()
    {
        

    }
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        if(isSelected==false)
        {
            isSelected = true;
            Debug.Log("isSelected - TRUE");
        }
        else
        {
            isSelected = false;

            Debug.Log("isSelected - FALSE");
        }
        ListForSelectedCardsFill();
        
    }
    
    
    void ListForSelectedCardsFill()
    {
        if(isSelected == true)
        { 
            deckFill = GameObject.FindGameObjectWithTag("Deck");
            cardIndexToAdd = GetComponent<CardInformation>();
            listOfCards = deckFill.GetComponent<CheckCombinations>();
            
            if (listOfCards.listOfIndexes.Count < 5)
            {
                listOfCards.listOfIndexes.Insert(0, cardIndexToAdd.cardIndex);//fill the lists
                listOfCards.listOfColors.Insert(0, cardIndexToAdd.color);//fill the lists
                listOfCards.listOfVec3.Insert(0, transform.position);
                listOfCards.listOfTargetsToDestroy.Insert(0, gameObject);
            }
            }
        if (isSelected == false)
        {
            listOfCards.listOfColors.Remove(cardIndexToAdd.color);
            listOfCards.listOfIndexes.Remove(cardIndexToAdd.cardIndex);
            listOfCards.listOfVec3.Remove(transform.position);
            listOfCards.listOfTargetsToDestroy.Remove(gameObject);
        }

    }

}



// GameObject.FindGameObjectWithTag("Deck").GetComponent<SelectedCards>().selectedCards.Add(GetComponent<CardInformation>().cardIndex);
/*

void ListForSelectedCardsFill()
    {
        if(isSelected == false)
        { 
            DeckFill = GameObject.FindGameObjectWithTag("Deck");
            cardIndexToAdd = GetComponent<CardInformation>();
            listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();
            
            
            if(listOfSelectedCards.selectedCards.Count < 5)
            {
                listOfSelectedCards.selectedCards.Insert(0, cardIndexToAdd.cardIndex);//fill the lists
                listOfSelectedCards.selectedCardsColors.Insert(0, cardIndexToAdd.color);//fill the lists
            }
            if(listOfSelectedCards.selectedCards.Count == 5)
            {
               // Debug.Log("Maximum cards inputed");
            }



            /*
             if(listOfSelectedCards.selectedCards.Count < 3)
             {
                 SendButton.SetActive(false);
             }
             else
             {
                 SendButton.SetActive(true);
             }
            
isSelected = true;
        }
    }


    /*
   void ReplaceAndDestroyCards()
    {
        if (isSelected == true && listOfCards.legitCombination == true)
        {
            deckFill = GameObject.FindGameObjectWithTag("Deck");
            deck = deckFill.GetComponent<Dekk>();
            selectedCardTransform = transform.position;
            i = Random.Range(0, deck.cards.Count);
            GameObject g = Instantiate(deck.cards[i], selectedCardTransform, Quaternion.identity) as GameObject;
            Debug.Log(deck.cards[i]);
            deck.cards.Remove(deck.cards[i]);
            
            Debug.Log(isLegitCombination);
            Debug.Log(listOfCards.legitCombination);
            Destroy(gameObject);

            //listOfCards.legitCombination = false;
            //isSelected = false;
            isLegitCombination = false;
            if (listOfCards.legitCombination == true)
            {
                
            }
        }
        
        //listOfCards.legitCombination(false);
    }.

    */
    
  



// cards = GetComponent<CardInformation>();   //within the same object, thats why we dont need to specify object
// cardy = eventData.selectedObject;
//cardIndexCopy = cards.cardIndex;

//n++; 
//selectedCards.Insert(0, cardIndexCopy);
// cardIndex = eventData.rawPointerPress;
//Debug.Log(selectedCards[0]);
//Debug.Log(n);
//Debug.Log(selectedCards[1]);
//Debug.Log(cardIndexCopy);
//Debug.Log(selectedCards.Count);

/*
if(isSelected == false)
    { 

        DeckFill = GameObject.FindGameObjectWithTag("Deck");
        cardIndexToAdd = GetComponent<CardInformation>();
        listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();

        if(listOfSelectedCards.selectedCards.Count < 5)
        {
            listOfSelectedCards.selectedCards.Insert(0, cardIndexToAdd.cardIndex);

        }
        if(listOfSelectedCards.selectedCards.Count == 5)
        {
            Debug.Log("Maximum cards inputed");
        }

        isSelected = true;
    }
*/

/*
         cards = GetComponent<CardInformation>();
         cardIndexCopy = cards.cardIndex;
         n++; 
         selectedCards.Insert(0, cardIndexCopy);
         // cardIndex = eventData.rawPointerPress;
         Debug.Log(selectedCards[0]);
         Debug.Log(n);
         //Debug.Log(selectedCards[1]);
         //Debug.Log(cardIndexCopy);
         Debug.Log(selectedCards.Count);

         if (OnClick != null)
         {
             OnClick();
         }
         Debug.Log("§§§§§§§§§§§§§§§§§§§§§§§§§§§");*/
