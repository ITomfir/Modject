using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IDialogPointer { 
    event Action<BaseDialogModelData> OnTransition;
}
