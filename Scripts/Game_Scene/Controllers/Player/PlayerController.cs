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
        private ICameraSystem _cameraSystem;
        private void Awake()
        {
            _inputSystem = this.transform.AddComponent<KeyboardDefaultInputSystem>();
            _cameraSystem = this.transform.AddComponent<DefaultCameraSystemWithBobbing>();
        }

        void Update()
        {

            _inputSystem.Move(speed, this.gameObject);
            _cameraSystem.Camera_Rotate(sensitivity, smoothing, _camera_parent, _player);

        }
        

    }
}