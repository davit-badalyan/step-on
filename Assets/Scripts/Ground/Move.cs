using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Player player;
    public float speed = 3.0f;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void Update()
    {
        MoveBack();
    }

    private void MoveBack()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
