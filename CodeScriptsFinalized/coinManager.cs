using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro.Examples;
using UnityEngine.SceneManagement;

public class coinManager : MonoBehaviour
{
    public int CoinCount;

    public Text coinText;

    void Update()
    {
        coinText.text = "Score: " + CoinCount.ToString();
    }
    
}
