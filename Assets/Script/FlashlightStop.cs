using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightStop : MonoBehaviour
{
    public GameObject flashlight;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            flashlight.SetActive(false);
            Invoke("Reopen", 5f);
        }
    }

    void Reopen()
    {
        flashlight.SetActive(true);
    }
}
