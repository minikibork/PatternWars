using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour {

    List<int> cards;// new List<int>

    public IEnumerable<int> GetCards()
    {
        foreach(int i in cards)
        {
            yield return i;
        }
    }

    public void Shuffle()
    {
        if(cards == null)
        {
            cards = new List<int>();
        }
        else
        {
            cards.Clear();
        }


        for (int i = 0; i < 84; i++)
        {
            cards.Add(i);
        }   //here you can change how many cards there are, and several other places

        int n = cards.Count;//n is the random number
        while(n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1); //k is the id we want to change
            int temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }

	// Use this for initialization
	void Awake ()
    {
        Shuffle();
	}
}
