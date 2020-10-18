using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        PressX();
    }

    void PressX()
    {
        if (Input.GetKeyDown(KeyCode.X)){
            Debug.Log("keyDownX");
            transform.position = new Vector3(transform.position.x, 0.05f, transform.position.z);
        }
    }

}
