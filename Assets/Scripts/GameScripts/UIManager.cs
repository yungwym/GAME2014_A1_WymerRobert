using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI moneyText;

    [SerializeField] Shop shop;
    [SerializeField] Score score;
    [SerializeField] PlayerController playerController;

    private void Start()
    {
        healthText.text = playerController.GetPlayerHealth().ToString();
        scoreText.text = score.GetPlayerScore().ToString();
        moneyText.text = shop.GetMoneyAmount().ToString();
    }

    private void Update()
    {
        healthText.text = playerController.GetPlayerHealth().ToString();
        scoreText.text = score.GetPlayerScore().ToString();
        moneyText.text = shop.GetMoneyAmount().ToString();

        if (playerController.PlayerDeath())
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
