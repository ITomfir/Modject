using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class DialogButton : MonoBehaviour, IDisposable
{
    [SerializeField] private Button _button;
    [SerializeField] private TMP_Text _text;

    public void Init(string text, Action onClick) {
        _text.text = text;
        _button.onClick.AddListener(()=>onClick?.Invoke());
    }

    public void Dispose() {
        _button.onClick.RemoveAllListeners();
    }
}
