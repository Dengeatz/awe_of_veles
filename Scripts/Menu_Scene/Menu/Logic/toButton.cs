using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class toButton : MonoBehaviour
    {
        public Canvas canvas;
        public Canvas _this_canvas;
        public void Button_Clicked()
        {
            EventBus.next_canvas?.Invoke(canvas, _this_canvas);
        }
    }
}