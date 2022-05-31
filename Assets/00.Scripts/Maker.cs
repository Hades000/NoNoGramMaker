using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker : MonoBehaviour
{
    public Texture2D texture;

    public int[,] board;

    private void Start()
    {
        SetBoard(texture.width);
    }

    private void SetBoard(int size)
    {
        board = new int[size,size];

        for (int i = 0; i < texture.width; i++)
        {
            for (int j = 0; j < texture.height; j++)
            {
                board[i,j] = (texture.GetPixel(j, i) == Color.black) ? 1 : 0;
            }
        }

        ShowBoardState(size);
    }

    private void ShowBoardState(int size)
    {
        for (int i = 0; i < size; i++)
        {
            string tmp = "";
            for (int j = 0; j < size; j++)
            {
                tmp += board[i,j] + " ";
            }

            Debug.Log("Board Data" + tmp);
        }
    }
}
