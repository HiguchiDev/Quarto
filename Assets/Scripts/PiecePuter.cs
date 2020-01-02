using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecePuter
{
    public void put(PutParameter putParameter)
    {
        GameObject obj = (GameObject)Resources.Load("Cube");
        // Cubeプレハブを元に、インスタンスを生成、
        //Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
    }
}