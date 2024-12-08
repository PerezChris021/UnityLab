using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public PlayerHealth playerhealth;
    
   public void Restarting()
    {
        if (playerhealth.health <= 0)
        {
            
            SceneManager.LoadScene("SampleScene");
            
        }
    }
}
