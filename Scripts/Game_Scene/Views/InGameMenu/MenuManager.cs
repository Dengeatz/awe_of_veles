using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class MenuManager : MonoBehaviour
{
    private AnimationSystemFadeOutFabrics _animationFabric;
    private IAnimationSystemFadeout _animationSystem;
    [SerializeField] private Canvas _menu;
    private float _animationSpeed;
    private void Start()
    {
        _animationSpeed = _menu.GetComponent<InGameMenu.Menu>().animationSpeed;
        _animationFabric = new DefaultAnimationSystemFadeoutFabric();
        _animationSystem = _animationFabric.createAnimationSystemFadeout(_menu, _menu.GetComponent<CanvasGroup>(), _animationSpeed);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(_animationSystem.Status() == false)
            {
                _animationSystem.Open();
            } 
            else if(_animationSystem.Status() == true)
            {
                _animationSystem.Close();
            }
        }
    }
}
