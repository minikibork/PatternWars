using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SendButton : MonoBehaviour, IPointerDownHandler{

    public delegate void SentAction();
    public static event SentAction Sent;
    public List<int> selectedCardsSent = new List<int>();
    public List<int> selectedCardsFromEventManager = new List<int>();
    public GameObject DeckFill;
    SelectedCards listOfSelectedCards;
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

        //CheckForValidLenght();
    }
   

    public void FillWithZeros()
    {
        listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();
        DeckFill = GameObject.FindGameObjectWithTag("Deck");
        listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();
        if(listOfSelectedCards.selectedCards.Count > 2)
        { 
        while (listOfSelectedCards.selectedCards.Count > 2 && listOfSelectedCards.selectedCards.Count < 5)
        {
            listOfSelectedCards.selectedCards.Insert(0, 0);
        }

            selectedCardsSent = listOfSelectedCards.selectedCards;
            selectedCardsSent.Sort();
            hasBeenSend = true;
            Debug.Log(selectedCardsSent);
            if (Sent != null)
            {
                Sent();
            }
            /*Debug.Log(listOfSelectedCards.selectedCards[0]);
        Debug.Log(listOfSelectedCards.selectedCards[1]);
        Debug.Log(listOfSelectedCards.selectedCards[2]);
        Debug.Log(listOfSelectedCards.selectedCards[3]);
        Debug.Log(listOfSelectedCards.selectedCards[4]);
*/
        }
    }

    
    void Send()
    {

    }
}
