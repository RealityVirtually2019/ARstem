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
            		SceneManager.LoadScene("PlayScene");
                    break;
            case "PlayScene":
                    SceneManager.LoadScene("QuestionScene");
                    break;
            case "QuestionScene":
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

    public void BackToChooseLessonScene()
    {
        if (SceneManager.GetActiveScene().name == "PlayScene")
        {
            SceneManager.LoadScene("ChooseLessonScene");
        }
    }//BackToFindingTarget()

}
