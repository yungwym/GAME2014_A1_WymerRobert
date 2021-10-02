using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuController : MonoBehaviour
{
    
    public void PlayAgainButtonPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MainMenuButtonPressed()
    {
        SceneManager.LoadScene("StartScene");
    }


}
