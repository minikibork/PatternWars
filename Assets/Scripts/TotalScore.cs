using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {
    [SerializeField]
    private Text txt;
    [SerializeField]
    private CheckCombinations checkedCombinations;
    [SerializeField]
    private int totalScoreToDisplay = 0;
    [SerializeField]
    private GameObject deckFill;

    // Use this for initialization
    void Start () {
        checkedCombinations = deckFill.GetComponent<CheckCombinations>();
        txt = gameObject.GetComponent<Text>();
    }
	void DisplayTotalScore()
    {
        totalScoreToDisplay = checkedCombinations.TotalScore;
       
        txt.text = "Score : " + totalScoreToDisplay;
    }
	// Update is called once per frame
	void Update () {
        DisplayTotalScore();
    }
}
