using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu {
    public interface IButtonSoundBase
    {
        public void OnClick();
    }


    public class ButtonSoundDefault : IButtonSoundBase
    {

        public void OnClick()
        {
            Debug.Log("hello");
            //sound_source.PlayOneShot(sound_source.clip);
        }
    }
}