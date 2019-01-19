using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveResult : MonoBehaviour {

    private static string[] m_keywords = new string[] { "nucleotides", "adenine", "cytosine", "strand", "genes", "person", "monkey", "fly", "banana" };
    private ObjManager m_ObjectManager;
	// Use this for initialization

    void Start ()
    {
        m_ObjectManager = GameObject.Find("ObjectManager").GetComponent <ObjManager> ();
	}
	
    void onActivityResult(string recognizedText){
        char[] delimiterChars = {'~'};
        string[] result = recognizedText.Split(delimiterChars);
        string temp = result[0].ToLower();
        //You can get the number of results with result.Length
        //And access a particular result with result[i] where i is an int
        //I have just assigned the best result to UI text
        int key = 0;
        for (int i = 0; i < m_keywords.Length; i++)
        {
            if (temp.Contains(m_keywords[i]))
            {
                key = i;
                GameObject.Find("Text").GetComponent<Text>().text = temp;               
                break;
            }
        }
        m_ObjectManager.HandleAction(key);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
