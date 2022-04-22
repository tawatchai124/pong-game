using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] private Text playerText;
    [SerializeField] private Text aiPaddleText;

    private int playerScore = 0;
    private int aiPaddleScore = 0;

    public void UpdatePlayerScore()
    {
        playerScore++;
        playerText.text = playerScore.ToString();
    }

    public void UpdateAIPaddleScore()
    {
        aiPaddleScore++;
        aiPaddleText.text = aiPaddleScore.ToString();
    }

}
