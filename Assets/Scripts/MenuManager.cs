using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text bestScoreText;

    void Start()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        string bestPlayer = PlayerPrefs.GetString("BestPlayer", "None");

        bestScoreText.text = $"Best Score : {bestPlayer} : {bestScore}";
    }

    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteKey("BestScore");
        PlayerPrefs.DeleteKey("BestPlayer");
        PlayerPrefs.Save();

        Debug.Log("Datos reiniciados");

        // Actualiza el texto en pantalla si quieres mostrar el cambio inmediatamente
        if (bestScoreText != null)
        {
            bestScoreText.text = $"Best Score : None : 0";
        }
    }
}

