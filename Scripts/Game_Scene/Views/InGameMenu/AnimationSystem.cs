using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IAnimationSystemFadeout 
{
    public void Init(Canvas _canvas, CanvasGroup _canvasGroup, float time = 1f);
    public void Open();
    public void Close();

    public bool Status();
}



public class DefaultAnimationSystem : MonoBehaviour, IAnimationSystemFadeout
{
    private GameObject _canvas_ui;
    private Canvas _canvas;
    private CanvasGroup _canvasGroup;
    private float _time;
    public bool isOpen = false;
    private Coroutine _coroutine;
    public void Init(Canvas _canvas, CanvasGroup _canvasGroup, float time = 1f)
    {
        this._canvas = _canvas;
        this._canvasGroup = _canvasGroup;
        this._time = time;
    }
    
    public bool Status()
    {
        return isOpen;
    }

    public void Open()
    {
        if(_coroutine == null)
        {
            _coroutine = StartCoroutine(Open_UI());
            isOpen = true;
        }
    }

    public void Close()
    {
        if (_coroutine == null)
        {
            _coroutine = StartCoroutine(Close_UI());
            isOpen = false;
        }
    }

    IEnumerator Open_UI()
    {
        for(float i = 0; i < 1f; i += Time.unscaledDeltaTime * _time)
        {
            _canvasGroup.alpha = i;
            yield return null;
        }
        _canvasGroup.alpha = 1f;
        _canvasGroup.interactable = true;
        _canvasGroup.blocksRaycasts = true;
        yield return new WaitForSecondsRealtime(0.1f);
        _coroutine = null;

    }

    IEnumerator Close_UI()
    {
        for(float i = 1f; i > 0f; i -= Time.unscaledDeltaTime * _time)
        {
            _canvasGroup.alpha = i;
            yield return null;
        }
        _canvasGroup.alpha = 0f;
        _canvasGroup.interactable = false;
        _canvasGroup.blocksRaycasts = false;
        yield return new WaitForSecondsRealtime(0.1f);
        _coroutine = null;
    }
}
