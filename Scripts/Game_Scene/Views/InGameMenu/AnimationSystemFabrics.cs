using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public abstract class AnimationSystemFadeOutFabrics
{
    public abstract IAnimationSystemFadeout createAnimationSystemFadeout(Canvas _canvas, CanvasGroup _canvasGroup, float time = 1f);
}

public class DefaultAnimationSystemFadeoutFabric : AnimationSystemFadeOutFabrics
{
    public override IAnimationSystemFadeout createAnimationSystemFadeout(Canvas _canvas, CanvasGroup _canvasGroup, float time = 1f)
    {
        DefaultAnimationSystem def = _canvas.AddComponent<DefaultAnimationSystem>();
        def.Init(_canvas, _canvasGroup, time);
        return def;
    }
}
