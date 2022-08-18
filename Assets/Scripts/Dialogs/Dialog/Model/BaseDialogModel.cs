using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseDialogModel : IDialogModel, INeedDialogManager
{
    protected IDialogManager _manager;

    public virtual void Iniject(IDialogManager manager) => _manager = manager;

    public virtual void OnShow() { }

    public virtual void OnClose() { }
}
