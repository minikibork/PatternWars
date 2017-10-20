using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectedCards : MonoBehaviour {
    public List<int> selectedCards = new List<int>();
    public int cardIndexCopy;
    //public int cardIndexCopyCopy;
    public CardInformation cardIndexSelected;
    private EventManager selectedCard;
    public GameObject SendButtonPlease;
    void OnEnable()
    {
        EventManager.OnClick += SelectedCardsList;
    }

    void OnDisable()
    {
        EventManager.OnClick -= SelectedCardsList;

    }
    // Use this for initialization
    void Start () {
        
    }

    void Update()
    {

        cardIndexSelected = gameObject.GetComponentInChildren<CardInformation>();
        //selectedCard = gameObject.GetComponentInChildren<EventManager>();
        CheckForValidLenght();
    }

    void SelectedCardsList()
    {

        cardIndexCopy = cardIndexSelected.cardIndex;
        selectedCards.Add(cardIndexCopy);
        Debug.Log(cardIndexCopy);
        //Debug.Log(selectedCards.Count);


    }


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

    // Update is called once per frame

}
//  cardIndexCopy = selectedCard.cardIndexCopy;
// cardIndexCopyCopy = cardIndexSelected.cardIndex;
//cardIndexCopy = cardIndexSelected.cardIndexCopy;
//selectedCards.Insert(0, cardIndexCopy);
//cardIndexSelected = GetComponent<EventManager>();