using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pausePanel;

    [SerializeField] private TextMeshProUGUI powerUpText;

    [SerializeField] private Button playButton;

    [SerializeField] private Button restartGOButton;
    [SerializeField] private Button mainMenuButton;

    [SerializeField] private Button continueButton;
    [SerializeField] private Button restartPauseButton;

    private GameManager gameManagerScript;

    void Start()
    {
        
        gameManagerScript = FindObjectOfType<GameManager>();

        restartPauseButton.onClick.AddListener(gameManagerScript.RestartGame);
        restartGOButton.onClick.AddListener(gameManagerScript.RestartGameScene);
        continueButton.onClick.AddListener(gameManagerScript.ResumeGame);
        playButton.onClick.AddListener(gameManagerScript.PlayGame);
        mainMenuButton.onClick.AddListener(gameManagerScript.RestartGameScene);

    }

    public void ShowMainMenuPanel()
    {
        Time.timeScale = 0;
        mainMenuPanel.SetActive(true);
    }

    public void HideMainMenuPanel()
    {
        Time.timeScale = 1;
        mainMenuPanel.SetActive(false);
    }

    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
    }

    public void HidePausePanel()
    {
        pausePanel.SetActive(false);
    }

    public void ShowGameOverPanel()
    {
        //animalFedText.text = "Animals fed: " + animalsFed;
        gameOverPanel.SetActive(true);
        //animalFed2Text.text = "";
    }

    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }

    /*public void UpdateFed(int animalsFed)
    {
        animalFed2Text.text = "Animals Fed = " + animalsFed;
    }*/

}
