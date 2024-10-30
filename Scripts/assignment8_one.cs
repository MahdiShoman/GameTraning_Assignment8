using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int testRandomNumber =0;
        while (true) { 
        
            testRandomNumber= Random.Range(1,21);
            Debug.Log(testRandomNumber);
            if (testRandomNumber == 5) {
                continue;
            }
            if (testRandomNumber == 15)
            {
                break;
            }
        }
        Debug.Log("Done!!");

        
    }

 
}
