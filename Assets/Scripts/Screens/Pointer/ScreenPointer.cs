using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScreenPointer : MonoBehaviour, IScreenPointer
{
    public event Action<IScreen> OnTransition;

    [SerializeField] private Screen _screenTransition;

    public void Transition () {
        OnTransition?.Invoke(_screenTransition);
    }
}
