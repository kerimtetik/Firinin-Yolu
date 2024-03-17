using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int CoinCount;
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Pide sayýsý: "+CoinCount.ToString();
        if (CoinCount == 7)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }
}
