using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int playerLives = 3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = playerLives; i != -1  ; i--)
        {
            if (i == 3)
            {
                Debug.Log("Many lives");

            }
            else if (i == 1)
            {
                Debug.Log("The last life!");
            }
            else if (i==0) {
                Debug.Log("Game Over!");
            }
            
        }

    }

}
