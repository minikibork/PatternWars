using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LeaderBoard : MonoBehaviour
{
    [SerializeField]
    public GameObject deckFill;

    [SerializeField]
    private CheckCombinations checkedCombinations;
  
    [SerializeField]
    private Text score;

    void Start()
    {
        score = gameObject.GetComponent<Text>();
        checkedCombinations = deckFill.GetComponent<CheckCombinations>();
    }
    public void HighScore()
    {
        if(checkedCombinations.TotalScore > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", checkedCombinations.TotalScore);
            
        }
        score.text = "HighScore : " + PlayerPrefs.GetInt("Highscore", 0);
    }

    void Update()
    {
        HighScore();
    }

}

