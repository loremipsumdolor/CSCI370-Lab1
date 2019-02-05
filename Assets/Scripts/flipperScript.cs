using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperScript : MonoBehaviour
{
    public GameObject LeftFlipper, RightFlipper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftFlipper.transform.Rotate(0f, 0f, 33f);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            LeftFlipper.transform.Rotate(0f, 0f, -33f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            RightFlipper.transform.Rotate(0f, 0f, -33f);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            RightFlipper.transform.Rotate(0f, 0f, 33f);
        }
    }
}
