using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField, Header("Movements")]
        private protected float speed = 5f;
        [SerializeField, Header("Camera")]
         private protected float sensitivity = 1f;
        [SerializeField] 
        private protected float smoothing = 1f;
        [SerializeField] 
        public Animation anim;
        [SerializeField] 
        private protected GameObject _camera_parent;
        [SerializeField]
        private protected GameObject _player;
        // CameraShake
        

        private protected Rigidbody rb;
        private float hp = 100f;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }


    }
}