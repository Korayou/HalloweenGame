using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OnButtonQuitPress()
    {
        Application.Quit();
    }
    public void OnButtonPlayPress()
    {
        GameManager.firstRun = false;
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
}
