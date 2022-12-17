using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float maxVerticalDistance;

    void Update()
    {
        Vector3 playerPos = player.position;

        float y = transform.position.y;
        if (y < playerPos.y - maxVerticalDistance)
        {
            y = playerPos.y - maxVerticalDistance;
        }
        if (y > playerPos.y + maxVerticalDistance)
        {
            y = playerPos.y + maxVerticalDistance;
        }


        transform.position = new Vector3(playerPos.x, y, transform.position.z);
    }
}
