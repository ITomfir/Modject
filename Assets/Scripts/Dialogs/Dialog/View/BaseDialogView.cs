using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BaseDialogView : MonoBehaviour
{
    public abstract Type ModelType { get; }

    public abstract void Show();
    public abstract void Close();
    public abstract void Bind(object model);
}
