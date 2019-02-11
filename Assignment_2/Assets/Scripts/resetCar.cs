using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetCar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            transform.Rotate(0f, 0f, 0f);
            //Move car up 3 metres on Y axis
            transform.Translate(0, 3, 0);

            
        }
    }

}
