using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SendButton2 : MonoBehaviour, IPointerDownHandler
{

    public delegate void SentAction();
    public static event SentAction Sent;
    public List<int> selectedCardsSent = new List<int>();
    public List<int> selectedCardsFromEventManager = new List<int>();
    public GameObject DeckFill;
    SelectedCards listOfSelectedCards;
    public bool hasBeenSend = false;
    // Use this for initialization
    void Start()
    {

    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        hasBeenSend = true;
    }
 // Update is called once per frame
 void FixedUpdate()
 {
        //CheckForValidLenght();
    }


 public void FillWithZeros()
 {


         /*Debug.Log(listOfSelectedCards.selectedCards[0]);
     Debug.Log(listOfSelectedCards.selectedCards[1]);
     Debug.Log(listOfSelectedCards.selectedCards[2]);
     Debug.Log(listOfSelectedCards.selectedCards[3]);
     Debug.Log(listOfSelectedCards.selectedCards[4]);
*/
    }
}



