using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Menu
{
    public class GameManager : MonoBehaviour
    {
        void OnEnable()
        {
            Menu.EventBus.next_canvas += Canvas_Next;
        }

        void OnDisable()
        {
            Menu.EventBus.next_canvas -= Canvas_Next;
        }

        private void Canvas_Next(Canvas canvas, Canvas _this_canvas)
        {
            canvas.GetComponent<Animation_UI>().Animate(canvas, _this_canvas);
        }
    }
}