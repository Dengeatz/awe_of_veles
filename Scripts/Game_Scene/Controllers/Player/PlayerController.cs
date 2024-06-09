using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

namespace Player
{
    
    public class PlayerController : Player
    {
        private IInputSystems _inputSystem;
        Vector2 smoothV;
        Vector2 mouseLook;

        private void Awake()
        {
            _inputSystem = this.transform.AddComponent<KeyboardDefaultInputSystem>();       
        }

        void Update()
        {

            _inputSystem.Move(speed, this.gameObject, anim);
            Camera_Rotate();

        }
        
        private void Camera_Rotate()
        {
            var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
            smoothV.x = Mathf.Lerp(smoothV.x, md.x, 0.5f / smoothing);
            smoothV.y = Mathf.Lerp(smoothV.y, md.y, 0.5f / smoothing);
            mouseLook += smoothV;
            mouseLook.y = Mathf.Clamp(mouseLook.y, -60f, 60f);
            _camera_parent.transform.rotation = Quaternion.Euler(-mouseLook.y, mouseLook.x, 0);
            transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
            
        }
    }
}