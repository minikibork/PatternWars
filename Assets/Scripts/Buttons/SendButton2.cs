using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SendButton2 : MonoBehaviour, IPointerDownHandler
{

    public bool hasBeenSend = false;
   
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        hasBeenSend = true;
    }
 


}



