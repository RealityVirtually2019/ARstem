using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowProgressBarDots : MonoBehaviour
{
    public GameObject[] buttons;
    
    public Sprite onImg;
    public Sprite offImg;

    public static string[] triggers;

    public bool[] progressFlg;
    public bool[] onClickedFlg;

    public string temp = "";

    
    // Start is called before the first frame update
    void Start()
    {
        progressFlg = new bool[] { true, false, false, false, false, false, false, false, false, false, false };
        onClickedFlg = new bool[] { false, false, false, false, false, false, false, false, false, false, false };

        triggers = new string[] { "a", "b", "c", "d" , "e", "f" , "g", "h" , "i"};
        
        buttons = new GameObject[] {
            GameObject.Find("Button1"),
            GameObject.Find("Button2"),
            GameObject.Find("Button3"),
            GameObject.Find("Button4"),
            GameObject.Find("Button5"),
            GameObject.Find("Button6"),
            GameObject.Find("Button7"),
            GameObject.Find("Button8"),
            GameObject.Find("Button9"),
            GameObject.Find("Button10"),
            GameObject.Find("Button11")
        };
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        FillProgressBar();
        SetProgressBar();

        ShowProgress(temp);

        if (Input.GetKeyDown(KeyCode.A))
        {
            SwitchSprite(1);
        }
    }//Upfdate



    public void ShowProgress(string receivedTrigger)
    {
        for(int i=0; i<triggers.Length; i++)
        {
            if (receivedTrigger == triggers[i])
            {
                OnProgressBar(buttons[i]);
            }
        }
    }//ShowProgress



    public void SetProgressBar()
    {
        for(int i=0; i<buttons.Length; i++)
        {
            if (progressFlg[i] == true)
            {
                OnProgressBar(buttons[i]);
            }
            else
            {
                OffProgressBar(buttons[i]);
            }
        }

    }//SetProgressBar



    public void SwitchSprite(int buttonId)
    {
        if (progressFlg[buttonId] == true)
        {
            OnProgressBar(buttons[buttonId]);
            progressFlg[buttonId] = false;
            print("turn to off");
        }
        else
        {
            OffProgressBar(buttons[buttonId]);
            print("turn to on");
            progressFlg[buttonId] = true;
        }

    }//SwitchSprite


    void OnProgressBar(GameObject _button)
    {
        _button.GetComponent<Image>().sprite = onImg;
    }

    void OffProgressBar(GameObject _button)
    {
        _button.GetComponent<Image>().sprite = offImg;
    }

    void FillProgressBar()
    {
        int clickedButtonId = 0;
        //Register clicked button
        for (int i = 0; i < progressFlg.Length; i++)
        {
            if (onClickedFlg[i] == true)
            {
                clickedButtonId = i;
            }
        }


        for (int i=0; i<progressFlg.Length; i++)
        {
            if (i <= clickedButtonId)
            {
                progressFlg[i] = true;
            }
            else
            {
                progressFlg[i] = false;
            }
        }//for
    }//FillProgressBar
    

    public void enableOnClickedFlg(int buttonId)
    {
        for (int i = 0; i < onClickedFlg.Length; i++)
        {
            onClickedFlg[i] = false;
        }
        onClickedFlg[buttonId] = true;
    }
    //List<string[]> ReadCsv(string csvPath) {
    //    TextAsset csvFile;
    //    List<string[]> csvDatas = new List<string[]>();

    //    csvFile = Resources.Load(csvPath) as TextAsset;
    //    System.IO.StringReader reader = new System.IO.StringReader(csvFile.text);

    //    while (reader.Peek() != -1)
    //    {
    //        string line = reader.ReadLine();
    //        csvDatas.Add(line.Split(','));
    //    }
    //    Debug.Log(csvDatas[0][0]);
    //    Debug.Log(csvDatas[0][1]);
    //    Debug.Log(csvDatas[1][0]);
    //    print(csvDatas.GetType());

    //    return csvDatas;

    //}//ReadCsv



}
