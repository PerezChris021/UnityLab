using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallonManager : MonoBehaviour
{
    public int BallonCounter;

    //Scene currentScene = SceneManager.GetSceneByName("SampleScene");
    //Scene trackScene = SceneManager.GetSceneByName("SampleScene");

    void Update()
    {
        if (BallonCounter == 4 && SceneManager.GetActiveScene().Equals(SceneManager.GetSceneByName("SampleScene")) )
        {
              SceneManager.LoadScene("Sample1");
            //   currentScene = SceneManager.GetActiveScene();
           
        }

        if (BallonCounter == 6 && SceneManager.GetActiveScene().Equals(SceneManager.GetSceneByName("Sample1")) )
        {
              SceneManager.LoadScene("Sample2");
            //currentScene = SceneManager.GetActiveScene();


        }

        if (BallonCounter == 8 && SceneManager.GetActiveScene().Equals(SceneManager.GetSceneByName("Sample2")) )
        {
            SceneManager.LoadScene("Menu");
           // currentScene = trackScene;
        }
    }
}
