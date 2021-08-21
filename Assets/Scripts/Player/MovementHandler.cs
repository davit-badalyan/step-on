using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public Player player;
    public Transform[] FootTarget;
    public Vector3 startPosition = new Vector3(0, 0, 0);

    private void Start()
    {
        Resume();
    }

    private void Update()
    {
        KeepInCenter();
    }

    private void LateUpdate()
    {
        CheckGround();
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

    public void CheckGround()
    {
        for (int i = 0; i < FootTarget.Length; i++)
        {
            RaycastHit hit;
            int layerMask = 1 << 6;
            Transform foot = FootTarget[i];
            if(Physics.Raycast(foot.position, foot.TransformDirection(Vector3.down), out hit, Mathf.Infinity, layerMask))
            {
                // Debug.Log("hit");
                // foot.position = new Vector3(foot.transform.position.x, 0, foot.transform.position.z);
                Debug.DrawRay(foot.position, foot.TransformDirection(Vector3.down), Color.green);
            }
            else
            {
                Debug.DrawRay(foot.position, foot.TransformDirection(Vector3.down), Color.red);

            }
        }
    }
}
