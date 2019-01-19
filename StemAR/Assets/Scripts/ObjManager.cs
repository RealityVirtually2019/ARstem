using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject[] objects;
    void Start()
    {

    }

    public void HandleAction(int obj)
    {
        foreach (GameObject item in objects)
        {
            if (item == objects[obj])
            {
                item.SetActive(true);
            }
            else
                item.SetActive(false);
        }
    }

    public  void TurnOff()
    {
        foreach (GameObject item in objects)
        {
            item.SetActive(false);
        }
    }

}
