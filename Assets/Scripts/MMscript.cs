using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MMscript : MonoBehaviour
{
    



    public void startgame(){
        SceneManager.LoadScene("SampleScene");
    }

     public void optionsmenu(){
        
    }

    public void quitgame(){
    Application.Quit();
    }
}
