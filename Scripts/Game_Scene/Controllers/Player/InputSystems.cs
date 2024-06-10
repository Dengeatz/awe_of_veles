using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputSystems
{
    public void Move(float speed, GameObject _player, Animation anim);
}

public abstract class InputSystems : MonoBehaviour, IInputSystems
{
    public abstract void Move(float speed, GameObject _player, Animation anim);
}


public class KeyboardDefaultInputSystem : InputSystems
{
    float Vertical;
    float Horizontal;
    private float speed;
    private GameObject _player;

    public override void Move(float speed, GameObject _player, Animation anim)
    {
        this.speed = speed;
        this._player = _player;
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        if (Vertical != 0)
        {
            Forward();

        }
        if (Horizontal != 0)
        {
            Right();

        }

    }

    private void Forward()
    {

        _player.transform.position += _player.transform.forward * Vertical * speed * Time.deltaTime;
        //this.transform.position += this.transform.forward * speed * Time.deltaTime;
    }



    private void Right()
    {
        _player.transform.position += _player.transform.right * Horizontal * speed * Time.deltaTime;
    }
}