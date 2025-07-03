using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public InputField nameInput;

    public void StartGame()
    {
        DataManager.Instance.playerName = nameInput.text;
        SceneManager.LoadScene("main");
    }
}
