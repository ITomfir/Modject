using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogViewProvideer : MonoBehaviour, IDialogViewProvideer
{
    public BaseDialogView[] Get () {
        return GetComponentsInChildren<BaseDialogView>(true);
    }
}
