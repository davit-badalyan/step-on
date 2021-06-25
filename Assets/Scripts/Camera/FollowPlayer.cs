using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0.925f, 1.625f, -0.675f);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
