using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class Animation_UI : MonoBehaviour
    {
        [SerializeField] private float speed = 1.5f;

        private Canvas _canvas;
        private CanvasGroup _canvas_group => _canvas.GetComponent<CanvasGroup>();

        private Canvas _this_canvas { get; set; }
        private CanvasGroup _this_canvas_group => _this_canvas.GetComponent<CanvasGroup>();

        public void Animate(Canvas canvas, Canvas _this_canvas)
        {

            this._canvas = canvas;
            this._this_canvas = _this_canvas;
            StartCoroutine(Animate_Coroutine());

        }

        IEnumerator Animate_Coroutine()
        {
            _this_canvas_group.interactable = false;
            _this_canvas_group.blocksRaycasts = false;
            for (float i = 1; i > 0f; i -= Time.deltaTime * 2)
            {
                _this_canvas_group.alpha = i;
                yield return null;
            }
            _this_canvas_group.alpha = 0f;
            yield return null;
            for (float i = 0; i < 1f; i += Time.deltaTime * 2)
            {
                _canvas_group.alpha = i;
                yield return null;
            }
            _canvas_group.alpha = 1f;
            _canvas_group.interactable = true;
            _canvas_group.blocksRaycasts = true;


        }
    }
}