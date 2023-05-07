using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int score = 0;

    public static void increaseScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }

    public static void decreaseLive()
    {
        lives--;
        Debug.Log("Lives: " + lives);
    }
}
