using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishTrigger : MonoBehaviour
{
    public GameObject[] person;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            for(int i = 0; i < person.Length; i++)
            {
                person[i].SetActive(false);
            }
            
        }
    }

}
