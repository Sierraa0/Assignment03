using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text livesRemaining;
    // Update is called once per frame
    void Update()
    {
        livesRemaining.text = "Lives: " + Frog.playerLives;
    }
}
