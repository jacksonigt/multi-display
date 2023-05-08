using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    public TMPro.TextMeshPro posLabel;
    public TMPro.TextMeshPro displayIdxLabel;

    private void Update()
    {
        // https://docs.unity3d.com/Packages/com.unity.inputsystem@1.5/api/UnityEngine.InputSystem.Mouse.html

        var mousePos = Input.mousePosition;


        var relativePos = Display.RelativeMouseAt(mousePos);

        var screenIdx = relativePos.z;



        posLabel.text = $"x:{relativePos.x} y:{relativePos.y}";
        displayIdxLabel.text = $"The mouse is on display: {screenIdx}";

        

    }
}
