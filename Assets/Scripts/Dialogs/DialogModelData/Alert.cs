using UnityEngine.Localization;
using UnityEngine;
using System;

[CreateAssetMenu]
public class Alert : BaseDialogModelData
{
    [SerializeField] private string DownloadFile;
    [SerializeField] private LocalizedString LocalizedMessage;
    [SerializeField] private LocalizedString Confirmation;

    public override IDialogModel GetModel() {
        return new DialogModel(LocalizedMessage.GetLocalizedString(), new [] {
                ((string text, Action onClick)) (Confirmation.GetLocalizedString(), ()=>{ })
            });
    }
}
