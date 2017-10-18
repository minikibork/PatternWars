using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class EventManager : MonoBehaviour, IPointerDownHandler
{

    public delegate void ClickAction();
    public static event ClickAction OnClick;
    public List<int> selectedCards = new List<int>();
   // public int[] selected = new int[]
    PointerEventData cardIndex;
    GameObject cardy;
    CardInformation cards;
    public static int n=0;
    public int cardIndexCopy;
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        
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
        Debug.Log("§§§§§§§§§§§§§§§§§§§§§§§§§§§");
    }

}



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
