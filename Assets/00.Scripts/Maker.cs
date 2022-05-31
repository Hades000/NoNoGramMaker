using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker : MonoBehaviour
{
    public Texture2D texture;

    private void Start()
    {
        for(int i = 0 ; i< texture.width; i++)
        {
            for(int j = 0 ; j<texture.height; j++)
            {
                Debug.Log(texture.GetPixel(j,i));
            }
        }
    }
}
