using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public void OpenUrl(string url)
    {
        Application.OpenURL(url);
    }

    public void ShowDetails()
    {
        SceneManager.LoadScene("Details");
        //Scene detailsScene = SceneManager.GetSceneByName("Details");
        //SceneManager.SetActiveScene(detailsScene);
    }

    public void ShowAR()
    {
        SceneManager.LoadScene("SampleScene");
        //Scene mainScene = SceneManager.GetSceneByName("SampleScene");
        //SceneManager.SetActiveScene(mainScene);
    }
}
