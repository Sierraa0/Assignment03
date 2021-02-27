using UnityEngine;
using UnityEngine.UI;

public class DropDownExample : MonoBehaviour
{
    public Dropdown livesDropdown;
    public static int livesAmount;


    private void Start()
    {
        Frog.playerLives = 2;
        livesAmount = Frog.playerLives;
    }


    public void SetLives()
    {
        if (livesDropdown.value == 0)
        {
            Frog.playerLives = 2;
        }
        else if (livesDropdown.value == 1)
        {
            Frog.playerLives = 1;
        }
        else if (livesDropdown.value == 2)
        {
            Frog.playerLives = 3;
        }
        else if (livesDropdown.value == 3)
        {
            Frog.playerLives = 4;
        }
        else if(livesDropdown.value == 4)
        {
            Frog.playerLives = 6;
        }
        livesAmount = Frog.playerLives;
    }
}
