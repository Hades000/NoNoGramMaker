using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager ins;

    private void Awake()
    {
        if(ins == null)
            ins = this;
    }

    public void MakeTextData(int size, string[] row, string[] col, string fileName)
    {
        string data = size + "\n";

        for(int i = 0 ;i<row.Length;i++)
        {
            data += row[i] + "\n";
        }

        data+="\n";

        for(int i = 0 ;i<col.Length;i++)
        {
            data += col[i] + "\n";
        }

        Debug.Log(data);

        FileSave(data, fileName);
    }

    public void FileSave(string data, string fileName)
    {
        string path = "Assets/02.Resources/PuzzleData/" + fileName;
        StreamWriter sw = new StreamWriter(path);

        if(!File.Exists(path))
        {
            sw.WriteLine(data);
        }

        sw.Flush();
        sw.Close();
    }
}
