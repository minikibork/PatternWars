using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class EventManager : MonoBehaviour, IPointerDownHandler
{

    public delegate void ClickAction();
    public static event ClickAction OnClick;
    PointerEventData cardIndex;
    GameObject cardy;
    CardInformation cards;
    public int cardIndexCopy;
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        cards = GetComponent<CardInformation>();
        cardIndexCopy = cards.cardIndex;
       // cardIndex = eventData.rawPointerPress;
        cardy = eventData.selectedObject.GetComponent<GameObject>();
        Debug.Log(cardIndexCopy);
        if (OnClick != null)
        {
            OnClick();
        }
       
    }

}
