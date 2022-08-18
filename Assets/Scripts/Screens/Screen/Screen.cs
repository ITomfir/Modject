using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour, IScreen
{
    public void Show () {
        gameObject.SetActive(true);
    }

    public void Close () {
        gameObject.SetActive(false);
    }
}
