using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogManager : IDialogManager
{
    private List<BaseDialogView> _views = new List<BaseDialogView>();
    private Dictionary<Type, BaseDialogView> _viewsMap = new Dictionary<Type, BaseDialogView>();

    public void Init(IDialogViewProvideer provideer) {
        _views.AddRange(provideer.Get());
        
        foreach (var view in provideer.Get()) {
            _viewsMap.Add(view.ModelType, view);
        }
    }

    public void Show<TModel>(TModel model) where TModel : IDialogModel, INeedDialogManager {
        if (_viewsMap.TryGetValue(model.GetType(), out var view)) {
            model.Iniject(this);
            view.Bind(model);
            view.Show();
        } else {
            throw new ArgumentNullException($"{model} not in the library");
        }
    }

    public void Close<TModel>() where TModel : IDialogModel {
        if (_viewsMap.TryGetValue(typeof(TModel), out var view)) {
            view.Close();
        }
    }
}
