using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Deck))]
public class DeckBuilding : MonoBehaviour {

    Deck deck;

    public GameObject CardPrefab;
    public float CardOffset;
    public Vector3 start;
	// Use this for initialization
	void Start () {
        deck = GetComponent<Deck>();
        ShowCards();

	}
	
    void ShowCards()//we can feed them manually
    {
        int cardCount = 0;

        foreach(int i in deck.GetCards())//make 3 for loops for each row
        {
            float co = CardOffset * cardCount;//change later
            GameObject cardCopy = (GameObject)Instantiate(CardPrefab);
            Vector3 temp = start + new Vector3(co, 0f);
            cardCopy.transform.position = temp;
            CardInformation cardModel = cardCopy.GetComponent<CardInformation>();
            cardModel.cardIndex = i;
            cardCount++;

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
