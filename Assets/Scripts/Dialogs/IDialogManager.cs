using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDialogManager
{
    void Init(IDialogViewProvideer provideer);
    void Show<TModel>(TModel model) where TModel : IDialogModel, INeedDialogManager;
    void Close<TModel>() where TModel : IDialogModel;
}
