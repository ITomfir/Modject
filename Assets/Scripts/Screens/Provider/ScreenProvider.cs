using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenProvider : MonoBehaviour, IScreenProvider
{
    public IScreen[] Get () {
        return GetComponentsInChildren<IScreen>(true);
    }
}
