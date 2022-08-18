using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseOneShotModel<TModel> : BaseDialogModel where TModel : BaseDialogModel
{
    public void Close () => _manager.Close<TModel>();
}
