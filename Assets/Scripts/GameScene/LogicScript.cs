using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public static LogicScript instance;

    [SerializeField] int playerscore;
    [SerializeField] Text scoretext;

    [SerializeField] GameObject platform;
    Vector3 nextSpawnPoint;

    [SerializeField] GameObject GameOverPanelCrash;
    [SerializeField] GameObject GameOverPanelVortex;
    [SerializeField] GameObject GameOverPanelBH;
    [SerializeField] GameObject PausePanel;

    [SerializeField] KeyCode PauseKeyCode = KeyCode.Space;

    [SerializeField] Text HighscoreText;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Time.timeScale = 1f;

        for (int i = 0; i < 8; i++)
        {
            SpawnPlatform();
        }

        ShowHighScore();
    }
    void Update() 
    {
        if (Input.GetKeyDown(PauseKeyCode))
        {
            Debug.Log("Pause key pressed. Current time scale: " + Time.timeScale);
            if (Time.timeScale == 0)
                Resume();
                

            else
                Pause();
        }
    }

    public void SpawnPlatform()
    {
        GameObject temp = Instantiate(platform, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        Debug.Log("SpawnPlatform method called");
    }

    public void addScore()
    {
        playerscore++;
        scoretext.text = playerscore.ToString();
        UpdateHighscore();

    }
   
    void UpdateHighscore()
    {
        if (playerscore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerscore);
            ShowHighScore();
        }
    }

    void ShowHighScore()
    {
        if (PlayerPrefs.GetInt("HighScore", 0) > 0)
        {
            HighscoreText.gameObject.SetActive(true);
            HighscoreText.text = $"High Score : {PlayerPrefs.GetInt("HighScore")} ";
        }
    }
    
    public void ShowGameOverPanel(string panelType)
    {
        switch (panelType)
        {
            case "Crash":
                GameOverPanelCrash.SetActive(true);
                break;
            case "Vortex":
                GameOverPanelVortex.SetActive(true);
                break;
            case "BlackHole":
                GameOverPanelBH.SetActive(true);
                break;
        }
        Destroy(PausePanel);

    }
    void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Pause Called");
    }

    void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("Resume Called");
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
