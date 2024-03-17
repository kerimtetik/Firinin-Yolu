using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Zaman : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;


    void Update()
    {

        sayac.timer -= Time.deltaTime;

        if (sayac.timer <= 0f)
        {
            EndGame();
        }
        else
        {
            UpdateTimerText();
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    void UpdateTimerText()
    {

        timertext.text = sayac.timer.ToString("F0");
    }


}







