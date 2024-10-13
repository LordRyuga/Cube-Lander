using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamelost : MonoBehaviour
{

    public void GameLost()
    {
        Canvas.enabled = true;
        Time.timeScale = 0;
    }

    public Transform pos;
    public Canvas Canvas;

    private void Start()
    {
        Canvas.enabled = false;
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(pos.position.y < -1)
        {
            GameLost();
        }
    }
}

