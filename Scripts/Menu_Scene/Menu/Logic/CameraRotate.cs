using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class CameraRotate : MonoBehaviour
    {
        [SerializeField] private float sensitivity = 1f;
        [SerializeField] private float smoothing = 5f;
        private float yCoordinate;
        Vector2 smoothV;
        Vector2 mouseLook;

        private void Start()
        {
            yCoordinate = this.transform.eulerAngles.y;
        }
        // Update is called once per frame
        void Update()
        {
            var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            md = Vector2.Scale(md, new Vector2(sensitivity * smoothing * Time.fixedDeltaTime, sensitivity * smoothing * Time.fixedDeltaTime));
            smoothV.x = Mathf.Lerp(smoothV.x, md.x, 0.5f / smoothing);
            smoothV.y = Mathf.Lerp(smoothV.y, md.y, 0.5f / smoothing);
            mouseLook += smoothV;
            mouseLook.y = Mathf.Clamp(mouseLook.y, -10f, 10f);

            mouseLook.x = Mathf.Clamp(mouseLook.x, yCoordinate - 10f, yCoordinate + 10f);
            transform.rotation = Quaternion.Euler(-mouseLook.y, mouseLook.x, 0);
        }
    }
}