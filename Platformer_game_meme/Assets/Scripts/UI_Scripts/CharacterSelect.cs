using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour

{
    public void GoToGame()
    {
        SceneManager.LoadScene("Player_Select");
    }
}
