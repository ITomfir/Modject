
using UnityEngine.Localization;
using UnityEngine;
using System;
using System.IO;

[CreateAssetMenu]
public class DownloadAfterAd : BaseDialogModelData
{
    [SerializeField] private string DownloadFile;
    [SerializeField] private LocalizedString LocalizedMessage;
    [SerializeField] private LocalizedString Confirmation;
    [SerializeField] private LocalizedString Cancel;

    public override IDialogModel GetModel() {
        return new DialogModel(LocalizedMessage.GetLocalizedString(), new [] {
                ((string text, Action onClick)) (Confirmation.GetLocalizedString(), ()=>{ AdManager.ShowAd(() => {
                    var filePash = Path.Combine(Application.dataPath, DownloadFile);
                    Debug.Log(filePash);
                    NativeFilePicker.ExportFile(filePash);
                });}), 
                ((string text, Action onClick)) (Cancel.GetLocalizedString(), ()=>{})
            });
    }
}
