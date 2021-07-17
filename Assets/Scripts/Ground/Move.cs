using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void FixedUpdate()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        transform.position = new Vector3(0, 0, player.transform.position.z);
    }
}
