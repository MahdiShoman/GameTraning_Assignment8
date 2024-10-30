using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assigment8two : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string[] strings = { "Cat", "Dog", "Car","Pizza" , "Hat", "Fish", "Tree", "Monkey","Ball" ,"Bird"  };

        int length = 7;
        int random = 0;
        string resultSectance = string.Empty;

        while (length!=0) { 

            random=  Random.Range(0, length+1 );
            resultSectance =    resultSectance + strings[random];

            length--;
        }

        Debug.Log(resultSectance);
        
    }

}
