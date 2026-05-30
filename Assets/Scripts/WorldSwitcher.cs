using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WorldSwitcher : MonoBehaviour
{
    public Button buttonA;
    public Button buttonB;
    public Button buttonC;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        UpdateButtons(SceneManager.GetActiveScene().name);
    }

    public void SwitchToWorld(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        UpdateButtons(sceneName);
    }

    private void UpdateButtons(string currentScene)
    {
        buttonA.interactable = currentScene != "World_A";
        buttonB.interactable = currentScene != "World_B";
        buttonC.interactable = currentScene != "World_C";
    }

}
