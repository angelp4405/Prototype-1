using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Vector3 topViewOffset = new Vector3(0, 5, -10);
    public Vector3 driverViewOffset = new Vector3(0, 1.5f, 0.5f);

    private bool isTopView = true;

    public KeyCode switchKey = KeyCode.C;

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            isTopView = !isTopView;
        }
    }

    void LateUpdate()
    {
        if (isTopView)
        {
            transform.position = player.transform.position + topViewOffset;
            transform.LookAt(player.transform);
        }
        else
        {
            transform.position = player.transform.position + player.transform.TransformDirection(driverViewOffset);
            transform.rotation = player.transform.rotation;
        }
    }
}