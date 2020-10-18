using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imitate : MonoBehaviour
{
    private Renderer targetRend;
    private Renderer myRend;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bcube")
        {
            Debug.Log("catchB");
            myRend.enabled = true;
            targetRend = collider.GetComponent<Renderer>();
            myRend.material = targetRend.material;
        }
    }
}
