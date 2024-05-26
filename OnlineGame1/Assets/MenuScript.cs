using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public float NewLightIntensity;
    public Light MyDirctionLifgth;
    public string sceneToLoad = "Game1";
    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);


    }


    public void QuitGame()
    {

        Application.Quit();
        Debug.Log("help");
    }

    public void DayMode()
    {
        SceneManager.LoadScene(1);
        NewLightIntensity = 1f;
        MyDirctionLifgth.intensity = NewLightIntensity;
    }




    public void NightMode()
    {
        SceneManager.LoadScene(1);
        // NewLightIntensity = 0f;
        //yDirctionLifgth.intensity = NewLightIntensity;
        OnSeneLoaded(sceneToLoad);
    }




    private void OnSeneLoaded(string scene)
    {
        Light mySceneLight = FindObjectOfType<Light>();
        if (mySceneLight != null && mySceneLight.tag=="GirLight")
            Debug.Log("1488");
        {
            mySceneLight.intensity = 0.0f;
            Debug.Log("hg");
        }
    
    
    }









}
