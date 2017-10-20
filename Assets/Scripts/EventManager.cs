
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class EventManager : MonoBehaviour, IPointerDownHandler
{

    public delegate void ClickAction();
    public static event ClickAction OnClick;
    /*
   public List<int> selectedCards = new List<int>();
   // public int[] selected = new int[]

   public PointerEventData cardIndex;
   public GameObject cardy;
   public CardInformation cards;
   public static int n=0;
   public int cardIndexCopy;
   public static int cardIndexCopy2;
   public bool isSelected;
   */

    public GameObject DeckFill;
    SelectedCards indexToAdd;
    CardInformation cardIndexToAdd;
    void Start()
    {
        //isSelected = false;
        
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        DeckFill = GameObject.FindGameObjectWithTag("Deck");
        cardIndexToAdd = GetComponent<CardInformation>();
        indexToAdd = DeckFill.GetComponent<SelectedCards>();
        indexToAdd.selectedCards.Insert(0,cardIndexToAdd.cardIndex);
        Debug.Log("§§§§§§§§§§§§§§§§§§§§§§§§§§§");
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
