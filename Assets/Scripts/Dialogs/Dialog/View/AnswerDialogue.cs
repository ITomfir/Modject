using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class AnswerDialogue : GenericDialogView<DialogModel>
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private DialogButton[] _buttons;
    [SerializeField] private Button[] _close;  

    public override void OnBind(DialogModel model) {
        _text.text = model.MessageText;

        foreach (var close in _close) {
            close.onClick.AddListener(()=> {
                model.Close();
            });
        }

        if (_buttons.Length >= model.Buttons.Length) {
            foreach (var button in _buttons) {
                button.gameObject.SetActive(false);
            }

            for (int i = 0; i < model.Buttons.Length; i++) {
                var index = i;
                _buttons[index].gameObject.SetActive(true);

                _buttons[index].Init(model.Buttons[i].text, () => {
                    model.Buttons[index].onClick?.Invoke();
                    model.Close();
                });
            }
        } else {
            throw new IndexOutOfRangeException();
        }
    }
}
