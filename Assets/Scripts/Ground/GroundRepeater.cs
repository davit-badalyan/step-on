using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRepeater : MonoBehaviour
{
    private Vector3 startPos;
    public float repeatWidth = 25.0f;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        CheckForRepeat();
    }

    private void CheckForRepeat()
    {
        if (transform.position.z < startPos.z - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
