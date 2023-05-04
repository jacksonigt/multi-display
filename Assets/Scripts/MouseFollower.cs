using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public List<Camera> cameras = new List<Camera>();

    void Update()
    {
        var mouse = UnityEngine.InputSystem.Mouse.current;
        var mouseDisplayIdx = mouse.displayIndex.ReadValue();
        var cam = cameras[mouseDisplayIdx];
        var mouseWorldPos = cam.ScreenToWorldPoint(mouse.position.ReadValue());
        transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 2);
    }
}
