using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IDialogModel : INeedDialogManager {
    void OnShow();
    void OnClose();
}
