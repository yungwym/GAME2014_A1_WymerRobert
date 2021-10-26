/*
 * Program Header: End Menu Controller 
 * Robert Wymer - 101070567
 * Last Date Modified - Oct 3, 2021
 * Version 1.0
 * 
 * Basic Scene Navigation for Start Menu
 * 
 * 
 * 
 */


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
