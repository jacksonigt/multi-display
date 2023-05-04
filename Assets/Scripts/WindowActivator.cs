using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowActivator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!Application.isEditor)
        {
            ActivateGameWindows();
        }
    }

    
    // https://docs.unity3d.com/2022.2/Documentation/ScriptReference/Display.SetParams.html
    void ActivateGameWindows()
    {
        // https://docs.unity3d.com/2022.2/Documentation/ScriptReference/Display.Activate.html
        // Check the number of monitors connected.
        if (Display.displays.Length > 1)
        {
            // Activate the display 1 (second monitor connected to the system).
            Display.displays[1].Activate(0, 0, new RefreshRate() { numerator = 60, denominator = 1 });
        }
    }
}
