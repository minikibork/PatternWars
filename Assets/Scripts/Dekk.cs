using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dekk : MonoBehaviour
{

    public List<GameObject> cards = new List<GameObject>();
    public static int numSpawned = 0;
    int numToSpawn = 21;
    public int i;

    public int cols;
    public int rows;
    public float Xspace;
    public float Yspace;
    public float Xstart;
    public float Ystart;
    
    public void PutInPlace()
    {

        int i = Random.Range(0, cards.Count - 1);
        GameObject myObj = Instantiate(cards[i]) as GameObject;
        cards.Remove(cards[i]);
        numSpawned++;
        myObj.transform.position = transform.position;//newtransform;

    }
    public void PlaceCards()
    {
        
            for (int y = 0; y < cols; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    i = Random.Range(0, cards.Count - 1);
                    Vector3 spawnPos = new Vector3(Xstart + x * (1 + Xspace) + x, Ystart + y * (1 + Yspace) + y, 0);
                    GameObject g = Instantiate(cards[i], spawnPos, Quaternion.identity) as GameObject;
                    g.name = x + "/" + y; //coordinates for debuging purposes
                    g.transform.parent = gameObject.transform;
                    if (y == cols - 1 && x == rows - 1)
                    {
                        Debug.Log("Game is ready");
                        Debug.Log(cards.Count);
                    }
                }
            }
        
    }


    public void Shuffle()
    {

        Object[] subListObjects = Resources.LoadAll("Prefabs", typeof(GameObject));
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

    

    // Use this for initialization
    void Awake()
    {
        Shuffle();

        //PutInPlace();
    }
    void Start()
    {
        PlaceCards();
    }
    void Update()
    {
        
    }

}


