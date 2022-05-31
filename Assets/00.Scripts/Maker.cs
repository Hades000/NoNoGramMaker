using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker : MonoBehaviour
{
    public Texture2D texture;

    public int[,] board;

    private void Start()
    {
        SetBoard();
    }

    private void SetBoard()
    {
        for (int i = 0; i < texture.width; i++)
        {
            for (int j = 0; j < texture.height; j++)
            {
                board[i,j] = (texture.GetPixel(j, i) == Color.black) ? 1 : 0;
            }
        }
    }
}
