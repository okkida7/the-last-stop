using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackToOrigin : MonoBehaviour
{
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        player.position = new Vector3(-0.01f, 0.964f, -9.29f);
    }
}
