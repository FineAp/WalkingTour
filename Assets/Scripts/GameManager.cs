using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    private int score;

    public GameObject player;
    public GameObject OverSet;

    [SerializeField]
    private Text scoreTxt;

    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    void Update()
    {
       
    }



    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void Score()
    {
        score++;
        scoreTxt.text = "" + score;
    }
    
 
}
