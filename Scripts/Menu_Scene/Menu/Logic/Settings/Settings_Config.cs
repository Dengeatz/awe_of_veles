using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Settings_Config", menuName = "ScriptableObjects/Settings_Config")]
public class Settings_Config : ScriptableObject
{
    [SerializeField] public float _sound_volume;
    [SerializeField] public float _music_volume;
    [SerializeField] public string _resolution;
}
