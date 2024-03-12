using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private UIManager uiManager;

    private PlayerController playerControllerScript;

    private SpawnManager spawnManagerScript;

    void Start()
    {

        uiManager = FindObjectOfType<UIManager>();
        playerControllerScript = FindObjectOfType<PlayerController>();
        spawnManagerScript = FindObjectOfType<SpawnManager>();

        uiManager.ShowMainMenuPanel();
        uiManager.HidePausePanel();
        uiManager.HideGameOverPanel();

    }

    void Update()
    {
        PausePanel();
    }

    public void PlayGame()
    {
        uiManager.HideMainMenuPanel();

        spawnManagerScript.SpawnEnemyWave();
    }

    public void PausePanel()
    {
        if (Input.GetKeyDown("escape"))
        {
            uiManager.ShowPausePanel();
            Time.timeScale = 0;
        }
    }

    public void RestartGameScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        uiManager.HideMainMenuPanel();
    }

    public void ResumeGame()
    {
        uiManager.HidePausePanel();
        Time.timeScale = 1;
    }

}
