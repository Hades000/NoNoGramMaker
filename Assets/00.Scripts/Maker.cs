using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CHECK_TYPE {ROW, COL}

public class Maker : MonoBehaviour
{
    public Texture2D texture;
    public Transform cellParent;

    public Cell cellPrefabs;
    public Cell[,] board;

    public int[,] boardData;

    public string[] rowHint;
    public string[] colHint;

    private void Start()
    {
        SetBoard(texture.width);
        GenerateBoard(texture.width);
    }

    private void SetBoard(int size)
    {
        boardData = new int[size,size];
        board = new Cell[size,size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                boardData[size-(i+1),j] = (texture.GetPixel(j, i) == Color.black) ? 1 : 0;
            }
        }
    }

    private void GenerateBoard(int size)
    {
        int width = 600 / size;
        int height = 600 / size;

        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                board[y, x] = Instantiate(cellPrefabs);
                board[y, x].SetCell(cellParent, width, height, x, y, boardData[y,x]);
            }
        }
    }

    private string MakeHintData(int idx, CHECK_TYPE type)
    {
        string tmp = "";

        return tmp;
    }
}
