using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    public TMPro.TextMeshPro posLabel;
    public TMPro.TextMeshPro displayIdxLabel;

    private void Update()
    {
        var mouse = UnityEngine.InputSystem.Mouse.current;
        // https://docs.unity3d.com/Packages/com.unity.inputsystem@1.5/api/UnityEngine.InputSystem.Mouse.html
        
        var mousePos = mouse.position.ReadValue();
        var displayIdx = mouse.displayIndex.ReadValue();



        posLabel.text = $"x:{mousePos.x} y:{mousePos.y}";
        displayIdxLabel.text = $"The mouse is on display: {displayIdx + 1}";
    }
}
