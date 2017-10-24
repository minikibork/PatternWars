using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    float timeLeft = 300.0f;

    public Text text;

    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }


    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            Debug.Log("Time is up");
            //SceneManager.LoadScene(1);
        }
    }
}
