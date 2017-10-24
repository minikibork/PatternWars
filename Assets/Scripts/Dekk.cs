using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dekk : MonoBehaviour
{

    public List<GameObject> cards = new List<GameObject>(); 
    public int i;

    public int cols;
    public int rows;
    public float Xspace;
    public float Yspace;
    public float Xstart;
    public float Ystart;
    public int amountsOfCards;
    public Component[] cardIndexes;

    public List<int> listOfAllIndexesOnBoard = new List<int>();

    public void ShuffleButton()
    {
        cardIndexes = GetComponentsInChildren<CardInformation>();
        foreach (CardInformation card in cardIndexes)
        {
          if (amountsOfCards != listOfAllIndexesOnBoard.Count)
            {
                int n = card.cardIndex;
                listOfAllIndexesOnBoard.Add(n);
            }
        }

    }

    public void PlaceCards()
    {
        
            for (int y = 0; y < cols; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    i = Random.Range(0, cards.Count);
                    Vector3 spawnPos = new Vector3(Xstart + x * (1 + Xspace) + x, Ystart + y * (1 + Yspace) + y, 0);
                    GameObject g = Instantiate(cards[i], spawnPos, Quaternion.identity) as GameObject;
                    //g.name = x + "/" + y; //coordinates for debuging purposes
                    g.transform.parent = gameObject.transform;
                    cards.Remove(cards[i]);
                    amountsOfCards = cols * rows;
                }
            }
    }


    public void Shuffle()
    {
        
        Object[] subListObjects = Resources.LoadAll("Prefabs", typeof(GameObject));

        if (subListObjects == null)
        {
            Debug.Log("there are no prefabs to take");
            return;
        }

        foreach (GameObject subListObject in subListObjects)
        {
            GameObject lo = (GameObject)subListObject;
            cards.Add(lo);
        }

        int n = cards.Count;//n is the random number
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1); //k is the id we want to change
            GameObject temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }

    }
    
    void Awake()
    {
        Shuffle();

        
    }
    void Start()
    {
        PlaceCards();
    }
    void Update()
    {
        
    }

}


