using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearTrigger : MonoBehaviour
{
    public GameObject[] eventTrigger;
    public GameObject[] person;
    public GameObject flashlight;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            for (int i = 1; i < eventTrigger.Length; i++)
            {
                eventTrigger[i].SetActive(false);
            }
            flashlight.SetActive(false);
            Invoke("RestartFlashlight", 7f);
        }
    }

    public void RestartFlashlight()
    {
        flashlight.SetActive(true);
        for(int i=1; i<person.Length; i++)
        {
            person[i].SetActive(true);
        }
        this.gameObject.SetActive(false);
    }
}
