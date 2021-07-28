using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public Player player;
    public Vector3 startPosition = new Vector3(0, 0, 0);

    private void Start()
    {
        Resume();
    }

    private void Update()
    {
        KeepInCenter();
    }

    public void Resume()
    {
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
    }

    public void KeepInCenter()
    {
        transform.rotation = Quaternion.identity;
        transform.position = new Vector3(0, 0, transform.position.z);
    }
}
