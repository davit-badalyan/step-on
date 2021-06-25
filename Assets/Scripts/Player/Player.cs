using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player instance;
    public static Player Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("Player is NULL");
            }

            return instance;
        }
    }

    public InputHandler inputHandler;
    public MovementHandler movementHandler;
    public Vector3 startPosition = new Vector3(0, 0, 0);

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Resume();
    }

    private void Resume()
    {
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
    }
}
