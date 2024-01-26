using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string gameLevelName;
    [SerializeField] private GameObject initialMenuPanel;
    [SerializeField] private GameObject optionsPanel;
    public void Play()
    {
        SceneManager.LoadScene(gameLevelName);
    }
    public void OpenOptions()
    {
        initialMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }
    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
        initialMenuPanel.SetActive(true);
    }

    public void CloseGame()
    {
        Debug.Log("Game finished!");
        Application.Quit();
    }
}
