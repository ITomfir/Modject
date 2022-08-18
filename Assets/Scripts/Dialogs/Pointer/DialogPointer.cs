using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogPointer : MonoBehaviour, IDialogPointer
{
    public event Action<BaseDialogModelData> OnTransition;

    [SerializeField] private BaseDialogModelData data;

    public void Invike () {
        OnTransition?.Invoke(data);
    }
}
