using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Highlight : MonoBehaviour
{ 

    Dekk deck;
    public List<int> selectedCards = new List<int>();
    PointerEventData cardIndex;
    GameObject cardy;
    public CardInformation cards;
    public int cardIndexCopy;
    PointerEventData eventData;
    void OnEnable()
    {
        EventManager.OnClick += Highlighting;
    }

    void OnDisable()
    {
        EventManager.OnClick -= Highlighting;
        
    }

    void Start()
    {
        deck = GetComponent<Dekk>();
    }
    void Highlighting()
    {
        /*
        cards = GetComponent<CardInformation>();
        cardIndexCopy = cards.cardIndex;
        selectedCards.Insert(0, cardIndexCopy);
        // cardIndex = eventData.rawPointerPress;
        Debug.Log("we are alive, not");
        Debug.Log(selectedCards[0]);
        //Debug.Log(selectedCards[1]);
        //Debug.Log(cardIndexCopy);
        Debug.Log(selectedCards.Count);
        //Debug.Log("I am clicked");
        //Change sprites with Highlighted ones
        */
    }

}
