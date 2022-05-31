using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker : MonoBehaviour
{
    public Texture2D texture;
    public Transform cellParent;

    public Cell cellPrefabs;
    public Cell[,] board;

    public int[,] boardData;

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
            {;
                Debug.Log($"[{i},{j}]");
                boardData[size-(i+1),j] = (texture.GetPixel(j, i) == Color.black) ? 1 : 0;
            }
        }

        ShowBoardState(size);
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

    private void ShowBoardState(int size)
    {
        for (int i = 0; i < size; i++)
        {
            string tmp = "";
            for (int j = 0; j < size; j++)
            {
                tmp += boardData[i,j] + " ";
            }

            Debug.Log("Board Data" + tmp);
        }
    }
}
