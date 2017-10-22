using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectedCards : MonoBehaviour {
    public List<int> selectedCards = new List<int>(); //refactor, put in deck script the whole thing
    public List<int> selectedCardsColors = new List<int>();
    public int cardIndexCopy;
    //public int cardIndexCopyCopy;
   
    private EventManager selectedCard;
    GameObject Deck;
    public GameObject SendButtonPlease;
    public CardInformation cardIndexSelected;
    public Transform childTransform;
    public Combinations Combinations;
    CardInformation cardColorToAdd;
    // Use this for initialization
    void Start () {
        Deck = GameObject.FindGameObjectWithTag("Deck");
        Combinations = Deck.GetComponent<Combinations>();
    }

  
    void Update()
    {
        
        cardIndexSelected = gameObject.GetComponentInChildren<CardInformation>();
        childTransform = gameObject.GetComponentInChildren<Transform>();
        

        CheckForValidLenght();
        //ReplaceCards();
    }
    /*
    void ReplaceCards()
    {
        if (Combinations.isLegit == false)//placeholder
        {
            
        }
    }
    */
    void CheckForValidLenght()
    {
        if (selectedCards.Count < 3)
        {
            SendButtonPlease.SetActive(false);

        }
        else
        {
            
            SendButtonPlease.SetActive(true);
        }
    }

   
   
}