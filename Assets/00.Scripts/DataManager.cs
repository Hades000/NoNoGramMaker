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

        FileSave(data, fileName);
    }

    public void FileSave(string data, string fileName)
    {
        string path = "C:/Users/user/Desktop/NoNoGram/hint/" + fileName + ".txt";
        DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(path));

        Debug.Log("Path : " + path);

        if (!directoryInfo.Exists)
        {
            directoryInfo.Create();
        }

        FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

        StreamWriter writer = new StreamWriter(fileStream, System.Text.Encoding.Unicode);
        writer.WriteLine(data);
        writer.Close();
    }
}
