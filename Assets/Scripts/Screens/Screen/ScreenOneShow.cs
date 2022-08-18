using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOneShow : MonoBehaviour, IScreen
{
    public void Show () {
        gameObject.SetActive(true);
    }

    public void Close () {
        gameObject.SetActive(false);
    }
}
