using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{


public GameObject player;
    private Vector3 offset = new Vector3(1, 2, 1);
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}