using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader : MonoBehaviour
{

    TextAsset csvFile;
    List<string[]> csvDatas = new List<string[]>();

    void Start()
    {
        csvFile = Resources.Load("testCSV") as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(','));
        }
        Debug.Log(csvDatas[0][1]);

    }

}