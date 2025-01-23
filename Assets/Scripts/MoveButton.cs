using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    private bool _isDown;

    public delegate void MoveButtonDelegate();
    public event MoveButtonDelegate OnMoveButtonDown;

    private void Update()
    {
        if (_isDown)
        {
            OnMoveButtonDown?.Invoke();
            
        }
    }
    public void ButtonDown()
    {
        _isDown = true;
    }

    public void ButtonUp()
    {
        _isDown = false;
    }
}
