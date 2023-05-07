using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public bool gameOver = false;

    public void SetGameOver()
    {
        this.gameOver = true;
    }
}
