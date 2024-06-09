using Menu;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Button_Sound_Attach : MonoBehaviour
{
    [SerializeField] private Button_Type _button_type;
    private IButtonSoundBase _sound;


    void Start()
    {
        switch(_button_type)
        {
            case Button_Type.Default:
                _sound = new ButtonSoundDefault();
                break;
            default:
                _sound = new ButtonSoundDefault();
                break;
        }
        
    }

    public void onMouseClick()
    {
        _sound.OnClick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
