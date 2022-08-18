using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseDialogModelData : ScriptableObject {
    public abstract IDialogModel GetModel();
}
