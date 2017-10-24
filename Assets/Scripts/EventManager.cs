
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class EventManager : MonoBehaviour, IPointerDownHandler
{
    public List<GameObject> cards = new List<GameObject>();
    
    public GameObject deckFill;
    public CheckCombinations checkCombination;
    public CardInformation cardIndexToAdd;
    public bool isSelected;
    public bool isLegitCombination;
    public GameObject lastPressed;
    public Dekk deck;
    public GameObject self;
    public int n;
    public static int cardsDestroy = 0;
    [SerializeField]
    public GameObject party;
    [SerializeField]
    public GameObject party2;

    [SerializeField]
    public GameObject sendButon;
    [SerializeField]
    public SendButton2 sendButton;
    public Vector3 scale;
    void Start()
    {
        deckFill = GameObject.FindGameObjectWithTag("Deck");
        scale = transform.localScale;
        isSelected = false;
        sendButton = sendButon.GetComponent<SendButton2>();
        cardIndexToAdd = GetComponent<CardInformation>();
        checkCombination = deckFill.GetComponent<CheckCombinations>();

    }
    void isLegit()
    {
        if (isSelected == false)
        {
            scale.x = 1F;
            scale.y = 1F;
            transform.localScale = scale;
        }
    }
    void Update()
    {
       isLegit();
    }
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        if(isSelected == true)
        {
            isSelected = false;
        }
        else
        {
            isSelected = true;
            Vector3 scale = transform.localScale;
            scale.x = 2F;
            scale.y = 2F;
            transform.localScale = scale;
        }
        FillingLists();
        Particles();

        /*
        if (checkCombination.listOfIndexes.Count < 5)
        { 
            if (isSelected == false)
        {
            isSelected = true;
            Debug.Log("isSelected - TRUE");
               
                Vector3 scale = transform.localScale;
                scale.x = 2F;
                scale.y = 2F;
                transform.localScale = scale;
            }
        else
        {
            
                isSelected = false;
                Vector3 scale = transform.localScale;
                scale.x = 1F;
                scale.y = 1F;
                transform.localScale = scale;
            }
        }
        */
        // isLegit();
        /*
        switch (isSelected && (checkCombination.listOfIndexes.Count < 5))
        {
            case true:
                isSelected = false;
                Vector3 scale = transform.localScale;
                scale.x = 1F;
                scale.y = 1F;
                transform.localScale = scale;

                break;
            case false:
                

                isSelected = true;
                Vector3 scale2 = transform.localScale;
                scale2.x = 2F;
                scale2.y = 2F;
                transform.localScale = scale2;

                break;
        }
        if(isSelected == true)
        {

        }
        */


    }
    void FillingLists()
    {

        deckFill = GameObject.FindGameObjectWithTag("Deck");
        cardIndexToAdd = GetComponent<CardInformation>();
        checkCombination = deckFill.GetComponent<CheckCombinations>();
        
        if (isSelected == true)
        {
            if (checkCombination.listOfIndexes.Count < 5)
            {
                checkCombination.listOfIndexes.Insert(0, cardIndexToAdd.cardIndex);//fill the lists
                checkCombination.listOfColors.Insert(0, cardIndexToAdd.color);//fill the lists
                checkCombination.listOfVec3.Insert(0, transform.position);
                checkCombination.listOfTargetsToDestroy.Insert(0, gameObject);
                return;
            }

        }
        if (isSelected == false)
        {
                checkCombination.listOfIndexes.Remove(cardIndexToAdd.cardIndex);
                checkCombination.listOfColors.Remove(cardIndexToAdd.color);
                checkCombination.listOfVec3.Remove(transform.position);
                checkCombination.listOfTargetsToDestroy.Remove(gameObject);
               
        }

        /*
        switch (isSelected && (checkCombination.listOfIndexes.Count < 5))
        {
            case true:
                
                break;
            case false:
                break;
        }
         */
    }

    void Particles()
    {
        if (isSelected == true)
        {
            Vector3 trans = transform.position;
            Instantiate(party, trans, Quaternion.identity);  
        }
        if (isSelected == false)
        {
            Vector3 trans = transform.position;
            Instantiate(party2, trans, Quaternion.identity);
        }
       
    }

    /*
    IEnumerator ParticlesDestroy(GameObject particle, float particleLifetime)
    {
        particleSystem.particleEmitter.emit = false;
        DestroyImmediate(particle);
    }
    */
}



// GameObject.FindGameObjectWithTag("Deck").GetComponent<SelectedCards>().selectedCards.Add(GetComponent<CardInformation>().cardIndex);
/*

void ListForSelectedCardsFill()
    {
        if(isSelected == false)
        { 
            DeckFill = GameObject.FindGameObjectWithTag("Deck");
            cardIndexToAdd = GetComponent<CardInformation>();
            listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();
            
            
            if(listOfSelectedCards.selectedCards.Count < 5)
            {
                listOfSelectedCards.selectedCards.Insert(0, cardIndexToAdd.cardIndex);//fill the lists
                listOfSelectedCards.selectedCardsColors.Insert(0, cardIndexToAdd.color);//fill the lists
            }
            if(listOfSelectedCards.selectedCards.Count == 5)
            {
               // Debug.Log("Maximum cards inputed");
            }



            /*
             if(listOfSelectedCards.selectedCards.Count < 3)
             {
                 SendButton.SetActive(false);
             }
             else
             {
                 SendButton.SetActive(true);
             }
            
isSelected = true;
        }
    }


    /*
   void ReplaceAndDestroyCards()
    {
        if (isSelected == true && listOfCards.legitCombination == true)
        {
            deckFill = GameObject.FindGameObjectWithTag("Deck");
            deck = deckFill.GetComponent<Dekk>();
            selectedCardTransform = transform.position;
            i = Random.Range(0, deck.cards.Count);
            GameObject g = Instantiate(deck.cards[i], selectedCardTransform, Quaternion.identity) as GameObject;
            Debug.Log(deck.cards[i]);
            deck.cards.Remove(deck.cards[i]);
            
            Debug.Log(isLegitCombination);
            Debug.Log(listOfCards.legitCombination);
            Destroy(gameObject);

            //listOfCards.legitCombination = false;
            //isSelected = false;
            isLegitCombination = false;
            if (listOfCards.legitCombination == true)
            {
                
            }
        }
        
        //listOfCards.legitCombination(false);
    }.

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
if(isSelected == false)
    { 

        DeckFill = GameObject.FindGameObjectWithTag("Deck");
        cardIndexToAdd = GetComponent<CardInformation>();
        listOfSelectedCards = DeckFill.GetComponent<SelectedCards>();

        if(listOfSelectedCards.selectedCards.Count < 5)
        {
            listOfSelectedCards.selectedCards.Insert(0, cardIndexToAdd.cardIndex);

        }
        if(listOfSelectedCards.selectedCards.Count == 5)
        {
            Debug.Log("Maximum cards inputed");
        }

        isSelected = true;
    }
*/

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
