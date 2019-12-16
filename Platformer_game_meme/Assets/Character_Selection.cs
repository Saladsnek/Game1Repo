using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_Selection : MonoBehaviour
{

    public void Character_Selected_Manor()
    {
        PlayerPrefs.SetString("CharacterName", "Manor");
        SceneManager.LoadScene("Main_Game_Scene");
    }
    public void Character_Selected_Icia()
    {
        PlayerPrefs.SetString("CharacterName", "Icia");
        SceneManager.LoadScene("Main_Game_Scene");
    }
    public void Character_Selected_Ashen()
    {
        PlayerPrefs.SetString("CharacterName", "Ashen");
        SceneManager.LoadScene("Main_Game_Scene");
    }
    public void Character_Selected_Artemis()
    {
        PlayerPrefs.SetString("CharacterName", "Artemis");
        SceneManager.LoadScene("Main_Game_Scene");
    }
}
