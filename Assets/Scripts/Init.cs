using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Init : MonoBehaviour
{
    [SerializeField] private ScreenProvider screenProvider;
    [SerializeField] private DialogViewProvideer dialogProvideer;
    private List<ScreenPointer> screenPointers = new List<ScreenPointer>();
    private List<DialogPointer> dialogPointers = new List<DialogPointer>();
    private IScreenManager screenManager;
    private IDialogManager dialogManager;

    private void Awake () {
        screenManager = new ScreenManager();
        screenManager.Init(screenProvider);

        dialogManager = new DialogManager();
        dialogManager.Init(dialogProvideer);

        screenPointers.AddRange(FindObjectsOfType<ScreenPointer>(true));

        foreach (var pointer in screenPointers) {
            pointer.OnTransition += screenManager.Show;
        }
        
        dialogPointers.AddRange(FindObjectsOfType<DialogPointer>(true));

        foreach (var pointer in dialogPointers) {
            pointer.OnTransition += context => dialogManager.Show(context.GetModel());
        }
    }
}
