using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    public class Music_Slider : MonoBehaviour
    {
        [SerializeField] private Settings_Config _config;
        private Slider _slider;
        void Start()
        {
            _slider = this.transform.GetComponent<Slider>();
        }

        public void SetVolume()
        {
            _config._music_volume = _slider.value / 10;
        }
    }
}