using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManor : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("Main_Game_Scene");
    }
}
