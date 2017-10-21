
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class EventManager : MonoBehaviour, IPointerDownHandler
{
    public List<GameObject> cards = new List<GameObject>();
    public delegate void ClickAction();
    public static event ClickAction OnClick;
    public GameObject SendButton;
    public GameObject DeckFill;
    public SelectedCards listOfSelectedCards;
    public CardInformation cardIndexToAdd;
    public bool isSelected;

    public Vector3 selectedCardTransform;
    public GameObject lastPressed;
    public Dekk deck;
    GameObject decky;
    public int n;
    
    void Start()
    {
        
        isSelected = false;
        
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        ListForSelectedCardsFill();
        //lastPressed = eventData.lastPress;
        //ReplaceAndDestroyCards(isSelected);
        
    }
    void ReplaceAndDestroyCards(bool Hello) //TO BE FINISHED AFTER COMBINATIONS
    {
        decky = GameObject.FindGameObjectWithTag("Deck");
        deck = decky.GetComponent<Dekk>();

        selectedCardTransform = transform.position;
        //Debug.Log(selectedCardTransform);
        n++;
        GameObject g = Instantiate(deck.cards[n], selectedCardTransform, Quaternion.identity) as GameObject;
        Debug.Log(deck.cards[n]);
    }

    void ListForSelectedCardsFill()
    {
        if(isSelected == false)
        { 
            DeckFill = GameObject.FindGameObjectWithTag("Deck");
            cardIndexToAdd = GetComponent<CardInformation>();
            listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();
            
            if(listOfSelectedCards.selectedCards.Count < 5)
            {
                listOfSelectedCards.selectedCards.Insert(0, cardIndexToAdd.cardIndex);
                listOfSelectedCards.selectedCardsColors.Insert(0, cardIndexToAdd.color);
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
             */
            isSelected = true;
        }
    }
}



// GameObject.FindGameObjectWithTag("Deck").GetComponent<SelectedCards>().selectedCards.Add(GetComponent<CardInformation>().cardIndex);
/*
if (OnClick != null)
{
    Debug.Log(gameObject.name);
    OnClick();
}
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
