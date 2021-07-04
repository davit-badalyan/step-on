using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public Player player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.SetLeftLegActive();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.SetRightLegActive();
        }
    }
}
