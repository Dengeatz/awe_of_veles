using UnityEngine;

public class Music_Volume : MonoBehaviour
{
    [SerializeField] private AudioSource _music_source;
    [SerializeField] private Settings_Config _config;
    void Update()
    {
        _music_source.volume = _config._music_volume;
    }
}
