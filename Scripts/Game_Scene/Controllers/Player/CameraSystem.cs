using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;


public interface ICameraSystem
{
    public void Camera_Rotate(float sensitivity, float smoothing, GameObject _camera, GameObject _player);
}

public abstract class CameraSystem : MonoBehaviour, ICameraSystem
{
    public abstract void Camera_Rotate(float sensitivity, float smoothing, GameObject _camera, GameObject _player);
}
public class DefaultCameraSystemWithBobbing : CameraSystem
{
    Vector2 smoothV;
    Vector2 mouseLook;
    private float Horizontal;
    public override void Camera_Rotate(float sensitivity, float smoothing, GameObject _camera, GameObject _player)
    {
        Horizontal = Input.GetAxis("Horizontal");
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 0.5f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 0.5f / smoothing);
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -60f, 60f);
        _camera.transform.rotation = Quaternion.Euler(-mouseLook.y, mouseLook.x, -Horizontal * 5);
        _player.transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
    }
}