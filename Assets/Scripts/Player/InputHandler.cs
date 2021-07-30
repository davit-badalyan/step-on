using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Player player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.animationHandler.SetLeftTransition();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            player.animationHandler.SetRightTransition();
        }
    }
}
