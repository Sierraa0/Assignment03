using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public Button saveB;
    public Button loadB;
    public Button saveJSON;
    public static int playerLives = 2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Debug.Log("We Lost!");
            if (Score.CurrentScore > Score.MaxScore)
            {
                Score.MaxScore = Score.CurrentScore;
            }
            Score.CurrentScore = 0;
            playerLives--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (playerLives <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        save.lives = playerLives;
        save.score = Score.CurrentScore;
        return save;
    }

    public void SaveGame()
    {
        Save save = CreateSaveGameObject();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

        Debug.Log("Saved");
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            playerLives = save.lives;
            Score.CurrentScore = save.score;

            Debug.Log("Game Loaded");
            Time.timeScale = 1;
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }
}
