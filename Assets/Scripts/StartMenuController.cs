using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    
    public void StartButtonPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void InstructionButtonPressed()
    {
        SceneManager.LoadScene("InstructionsScene");
    }
}
