using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class Resolution_Settings : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _dropdown;
    [SerializeField] private Settings_Config _config;
    Resolution[] resolutions;
    void Start()
    {

        resolutions = Screen.resolutions;

        foreach (var resolution in resolutions) 
        {
            string res = resolution.width + "x" + resolution.height + "@" + Math.Round(resolution.refreshRateRatio.value, 2);
            _dropdown.options.Add(new TMP_Dropdown.OptionData(res));
        }
    }

    public void onApply()
    {
        _config._resolution = _dropdown.options[_dropdown.value].text;
        string[] user_resolution = _config._resolution.Split('x', '@');
        double refreshRATE;
        double.TryParse(user_resolution[2], out refreshRATE);
        Screen.SetResolution(int.Parse(user_resolution[0]), int.Parse(user_resolution[1]), FullScreenMode.ExclusiveFullScreen, new RefreshRate() { numerator = ((uint)refreshRATE), denominator = 1});
    }
}
