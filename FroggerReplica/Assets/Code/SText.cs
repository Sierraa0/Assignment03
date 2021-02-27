using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SText : MonoBehaviour
{
    public Text sText;

    public void Start()
    {
        sText.text = "The High Score is " + Score.MaxScore.ToString();
    }
}
