using System.Collections;
using System.Collections.Generic;
using System;

public abstract class GenericDialogView<TModel> : BaseDialogView where TModel : IDialogModel
{
    public override Type ModelType => typeof(TModel);
    protected TModel _model;

    
    public override void Show() {
        gameObject.SetActive(true);
        _model.OnShow();
    }
    
    public override void Close() {
        gameObject.SetActive(false);
        _model.OnClose();
    }

    public override void Bind(object model) {
        if (!(model is TModel)) throw new ArgumentException($"{model} not {typeof(TModel)}");
        
        _model = (TModel)model;
        OnBind((TModel)model);
    }

    public abstract void OnBind(TModel model);
}
