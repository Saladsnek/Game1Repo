using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("Prototype_Scene");
    }
}
