using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionMenuController : MonoBehaviour
{
    
    public void BackButtonPressed()
    {
        SceneManager.LoadScene("StartScene");
    }

}
