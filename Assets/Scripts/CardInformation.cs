using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInformation : MonoBehaviour {
    SpriteRenderer SpriteRenderer;
    public Sprite[] faces;
    public int cardIndex;


    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.sprite = faces[cardIndex];
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
