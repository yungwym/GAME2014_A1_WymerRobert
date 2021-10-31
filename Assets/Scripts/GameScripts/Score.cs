using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float playerScore = 0;

    public void AddToScore(float amount)
    {
        playerScore += amount;
    }

    public float GetPlayerScore()
    {
        return playerScore;
    }
}
