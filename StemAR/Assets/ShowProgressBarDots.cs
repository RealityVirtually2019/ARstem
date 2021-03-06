﻿using System.Collections;
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

    public string message = "";

    public ObjManager animationTrigger;
    public string temp;

    // Start is called before the first frame update
    void Start()
    {
        animationTrigger = GameObject.Find("ObjectManager").GetComponent<ObjManager>();
        progressFlg = new bool[] { true, false, false, false, false, false, false, false, false };
        onClickedFlg = new bool[] { false, false, false, false, false, false, false, false, false };

        triggers = new string[] { "nucleotides", "adenine", "cytosine", "strand", "person", "monkey", "fly", "banana" };
        //triggers = new string[] { "nucleotides", "adenine", "cytosine", "strand", "genes", "person", "monkey", "fly", "banana" };

        buttons = new GameObject[] {
            GameObject.Find("Button1"),
            GameObject.Find("Button2"),
            GameObject.Find("Button3"),
            GameObject.Find("Button4"),
            GameObject.Find("Button5"),
            GameObject.Find("Button6"),
            GameObject.Find("Button7"),
            GameObject.Find("Button8"),
            GameObject.Find("Button9")
        };

    }

    // Update is called once per frame
    void Update()
    {
        FillProgressBar();
        SetProgressBar();

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    ReceiveMessage2(temp);
        //}

    }//Upfdate

    //public void ReceiveMessage2(string receivedMsg)
    //{
    //    message = receivedMsg;
    //    GameObject.Find("DebugText").GetComponent<Text>().text = message;
    //    // print("Message Received");
    //    for (int i = 0; i < triggers.Length; i++)
    //    {
    //        if (receivedMsg == triggers[i])
    //        {
    //            enableOnClickedFlg(i);
    //        }
    //    }
    //}

    public void ReceiveMessage(string receivedMsg)
    {
        message = receivedMsg;
        //GameObject.Find("DebugText").GetComponent<Text>().text = message;
        // print("Message Received");
        for (int i = 0; i < triggers.Length; i++)
        {
            if (receivedMsg == triggers[i])
            {
                enableOnClickedFlg(i);
            }
        }
    }


    public void SetProgressBar()
    {
        for (int i = 0; i < buttons.Length; i++)
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


    //void ShowAnimation(){
    //    //Register clicked button
    //    animationTrigger.HandleAction(CheckClickedBar());
    //}

    void FillProgressBar()
    {
        for (int i = 0; i < progressFlg.Length; i++)
        {
            if (i <= CheckClickedBar())
            {
                progressFlg[i] = true;
            }
            else
            {
                progressFlg[i] = false;
            }
        }//for
    }//FillProgressBar


    int CheckClickedBar()
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
        return clickedButtonId;
    }


    public void enableOnClickedFlg(int buttonId)
    {
        for (int i = 0; i < onClickedFlg.Length; i++)
        {
            onClickedFlg[i] = false;
        }
        onClickedFlg[buttonId] = true;
        //enable only onclicked bar
        int animationId = CheckClickedBar() - 1;
        if (animationId == -1)
        {
            animationTrigger.HandleAction(0);
        }
        else
        {
            animationTrigger.HandleAction(animationId); //first one button is dummy (because we removed "genes")
        }
    }


    void OnProgressBar(GameObject _button)
    {
        _button.GetComponent<Image>().sprite = onImg;
    }

    void OffProgressBar(GameObject _button)
    {
        _button.GetComponent<Image>().sprite = offImg;
    }

}
