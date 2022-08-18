using System.Collections;
using System.Collections.Generic;
using System;
public class DialogModel : BaseOneShotModel<DialogModel>
{
    public DialogModel(string message, (string text, Action onClick)[] buttons)
    {
        MessageText = message;
        Buttons = buttons;
    }

    public (string text, Action onClick)[] Buttons { get; }

    public string MessageText { get; }
}