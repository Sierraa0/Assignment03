using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button Bye;

    public void exitGame()
    {
        Debug.Log("Game Exit");
        Application.Quit();
    }
}
