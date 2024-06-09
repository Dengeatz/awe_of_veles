using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public static class EventBus
    {
        public static Action<Canvas, Canvas> next_canvas;
    }
}