using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SendButton : MonoBehaviour, IPointerDownHandler{


    public List<int> selectedCardsFromEventManager = new List<int>();
    public GameObject DeckFill;
    SelectedCards listOfSelectedCards;
    CardInformation cardIndexToAdd;
    private EventManager EventManagery;
    public bool hasBeenSend = false;
    // Use this for initialization
    void Start () {
		
	}

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        FillWithZeros();
    }
    // Update is called once per frame
    void Update () {

        CheckForValidLenght();
    }


    void CheckForValidLenght()
    {
        listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();
        DeckFill = GameObject.FindGameObjectWithTag("Deck");

        if (listOfSelectedCards.selectedCards.Count < 3)
        {
            gameObject.SetActive(false);

        }
        else
        {
            gameObject.SetActive(true);
        }
    }

   

    public void FillWithZeros()
    {
        listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();
        DeckFill = GameObject.FindGameObjectWithTag("Deck");
        EventManagery = GetComponent<EventManager>();
        listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();
        if(listOfSelectedCards.selectedCards.Count > 2)
        { 
        while (listOfSelectedCards.selectedCards.Count > 2 && listOfSelectedCards.selectedCards.Count < 5)
        {
            listOfSelectedCards.selectedCards.Insert(0, 0);
        }

        listOfSelectedCards.selectedCards.Sort();
            Debug.Log(listOfSelectedCards.selectedCards[0]);
            Debug.Log(listOfSelectedCards.selectedCards[1]);
            Debug.Log(listOfSelectedCards.selectedCards[2]);
            Debug.Log(listOfSelectedCards.selectedCards[3]);
            Debug.Log(listOfSelectedCards.selectedCards[4]);
        }
    }

    
    void Send()
    {

    }
}
/*f(listOfSelectedCards.selectedCards.Count < 3)
                {
                    listOfSelectedCards.selectedCards.Insert(0, 0);
                     Debug.Log("vlqzohme i tuka daje");
                }*/
