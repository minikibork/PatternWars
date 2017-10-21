
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class EventManager : MonoBehaviour, IPointerDownHandler
{
    
    public delegate void ClickAction();
    public static event ClickAction OnClick;
    public GameObject SendButton;
    public GameObject DeckFill;
    public SelectedCards listOfSelectedCards;
    public CardInformation cardIndexToAdd;
    public bool isSelected;
    public Vector3 selectedCardTransform;
    public GameObject lastPressed;
    void Start()
    {
        
        isSelected = false;
        
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        ListForSelectedCardsFill();
        lastPressed = eventData.lastPress;
        selectedCardTransform = transform.position;
        //Instantiate(OBJECTIWANT, selectedCardTransform, Quaternion.identity) as GameObject;
        
       
        

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
                
            }
            if(listOfSelectedCards.selectedCards.Count == 5)
            {
                Debug.Log("Maximum cards inputed");
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
