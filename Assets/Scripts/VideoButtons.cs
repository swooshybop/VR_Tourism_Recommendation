using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.InputSystem;

public class VideoButtons : MonoBehaviour
{

    public InputActionProperty _AButtonPressed;
    public InputActionProperty _BButtonPressed;

    void Start()
    {
        _AButtonPressed.action.started += OnAButtonPresed;
        _BButtonPressed.action.started += OnBButtonPresed;
    }


    void OnAButtonPresed(InputAction.CallbackContext context)
    {

    }

    void OnBButtonPresed(InputAction.CallbackContext context)
    {

    }
}
