using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dekk : MonoBehaviour {

    public static List<GameObject> cards = new List<GameObject>();
    public static int numSpawned = 0;
    int numToSpawn = 21;
  

    //public GameObject CardPrefab;
    //public float CardOffset;
    public Vector3 start, startPosition;
    float x, y;
    public void PutInPlace()
    {
            //spawns item in array position between 0 and 100
            //int whichItem = Random.Range(0, 21);
            for(int i=0;i<21; i++)
        { 
            GameObject myObj = Instantiate(cards[i]) as GameObject;
            // cards.Remove(cards[whichItem]);
            numSpawned++;
            Vector3 newtransform = new Vector3(x, y, 0);
            myObj.transform.position = transform.position;
        }
    }

    public void Shuffle()
    {
                                
            Object[] subListObjects = Resources.LoadAll("Prefabs", typeof(GameObject));
            //This may be sloppy (I've only been programing for a short time) 
            //It works though :) 
            foreach (GameObject subListObject in subListObjects)
            {
                GameObject lo = (GameObject)subListObject;

                cards.Add(lo);
            }

            startPosition = transform.position;//not needed

        
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
    void Update()
    {
        
            //where your instantiated object spawns from
            for (int i = 0; i < 5; i++)
            {
                transform.position = new Vector3(i-5, 4f, 0);
               
                PutInPlace();
            }
            for (int i = 5; i < 10; i++)
            {
                
                transform.position = new Vector3(i-10, 2f, 0);
               
                PutInPlace();
            }
            for (int i = 10; i < 15; i++)
            {
               
                transform.position = new Vector3(i-15, 0, 0);
               
                PutInPlace();
            }
            for (int i = 15; i < 21; i++)
            {
                
                transform.position = new Vector3(i-25 -2f, 0);
              
                PutInPlace();
            }

        }
    }

