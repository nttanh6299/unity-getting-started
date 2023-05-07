using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (other.gameObject.tag != "Player")
        {
            Destroy(other.gameObject);
            GameManager.increaseScore();
        }
        else
        {
            GameManager.decreaseLive();
            if (GameManager.lives < 1)
            {
                Destroy(other.gameObject);
                Debug.Log("Game over");
            }
        }
    }
}
