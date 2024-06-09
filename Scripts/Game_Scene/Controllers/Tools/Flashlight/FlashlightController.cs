using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : FlashLight
{

    public GameObject camera_main;

    void Update()
    {
        Flashlight_Rotate();
    }

    private void Flashlight_Rotate()
    {
        transform.rotation = Quaternion.Lerp(this.transform.rotation, camera_main.transform.rotation, smooth);
    }
}
