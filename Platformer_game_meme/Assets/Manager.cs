using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject characterManor;
    public GameObject characterAshen;
    public GameObject characterIcia;
    public GameObject characterArtemis;
    void Start()
    {
        string character = PlayerPrefs.GetString("CharacterName");
        Debug.Log(character);

        if (character == ("Manor"))
        {
            Instantiate<GameObject>(characterManor);
        }
        else if (character == ("Ashen"))
        {
            Instantiate<GameObject>(characterAshen);
        }
        else if (character == ("Icia"))
        {
            Instantiate<GameObject>(characterIcia);
        }
        else if (character == ("Artemis"))
        {
            Instantiate<GameObject>(characterArtemis);
        }
    }
}
