using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
[System.Serializable]
public struct cardLists
{
    public List<int> combination;
    public int score;
}
*/
public class Combinations2 : MonoBehaviour
{
    Dekk deck;
    public int TotalScore;


    [SerializeField]
    public List<cardLists> cardCombinations;

    [SerializeField]
    private List<int> myList;

    private int counter;
    public bool isLegit = false;

    [SerializeField]
    private SelectedCards selectedCards;

    private SendButton sendButton;


    public GameObject sendButtonG;

    void Start()
    {

    }
    void Update()
    {
        LegitCombination();
    }

    void CheckIfSend()
    {

        sendButton = sendButtonG.GetComponent<SendButton>();

        if (sendButton.hasBeenSend == true)
        {

            LegitCombination();
            Debug.Log("in the iff");
        }
        sendButton.hasBeenSend = false;
    }

    void LegitCombination()
    {
        selectedCards = GetComponent<SelectedCards>();
        myList = selectedCards.selectedCards;
        myList.Sort();

        for (int i = 0; cardCombinations.Count - 1 > i; i++)
        {
            cardCombinations[i].combination.Sort();//sort all combinations
        }


        for (int i = 0; i < cardCombinations.Count - 1; i++)
        {
            counter = 0;

            if (cardCombinations[i].combination.Count == myList.Count)
            {
                for (int b = 0; b < cardCombinations[i].combination.Count; b++)
                {
                    if (cardCombinations[i].combination[b] == myList[b])
                    {
                        counter++;
                    }
                    else
                    {
                        Debug.Log("Not a valid combination");
                        break;
                    }
                }
                if (counter == myList.Count)
                {
                    TotalScore += cardCombinations[i].score;
                    Debug.Log(i);
                    Debug.Log(TotalScore);
                    break;

                }
                counter = 0;
                selectedCards.selectedCards.Clear();
            }
        }
    }


    void OptimalScore()
    {

    }
}