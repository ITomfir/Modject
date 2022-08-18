using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScreenManager
{
    void Init (IScreenProvider provider);
    void Show (IScreen screen);
    void Close (IScreen screen);
}
