using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScene()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "TitleScene":
                    SceneManager.LoadScene("ChooseLessonScene");
                    break;
            case "ChooseLessonScene":
                    SceneManager.LoadScene("FindingTargetScene");
                    break;
            case "FindingTargetScene":
                    SceneManager.LoadScene("StartScene");
                    break;
            case "StartScene":
                    SceneManager.LoadScene("GameScene_temp");
                    break;
            case "GameScene_temp":
                SceneManager.LoadScene("EndScene");
                break;
            case "EndScene":
                SceneManager.LoadScene("TitleScene");
                break;

        }
    }//SwitchScene()


    public void QuitGame()
    {
        if (SceneManager.GetActiveScene().name == "EndScene") { 
            print("Quitting Application");
            Application.Quit();
        }
    }//QuitGame()

    public void BackToFindingTarget()
    {
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            SceneManager.LoadScene("FindingTargetScene");
        }
    }//BackToFindingTarget()

}
