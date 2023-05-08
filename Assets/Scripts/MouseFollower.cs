using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public List<Camera> cameras = new List<Camera>();

    void Update()
    {
        var mousePos = Input.mousePosition;
        var displayIdx = mousePos.z;
        var cam = cameras[(int)displayIdx];
        var mouseWorldPos = cam.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 2);
    }
}
