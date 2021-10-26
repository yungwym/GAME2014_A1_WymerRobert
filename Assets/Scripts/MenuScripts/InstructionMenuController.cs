/*
 * Program Header: Instruction Menu Controller 
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

public class InstructionMenuController : MonoBehaviour
{
    
    public void BackButtonPressed()
    {
        SceneManager.LoadScene("StartScene");
    }

}
