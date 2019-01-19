using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFindTargetUI : MonoBehaviour
{
    public Sprite emptyBg;
    public Sprite FindTargetBg;

    // Start is called before the first frame update
    void Start()
    {
        HideFindTargetBg();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideFindTargetBg()
    {
        GameObject.Find("FindTarget").GetComponent<Image>().sprite = emptyBg;
    }

    public void ShowFindTargetBg()
    {
        GameObject.Find("FindTarget").GetComponent<Image>().sprite = FindTargetBg;
    }


}
