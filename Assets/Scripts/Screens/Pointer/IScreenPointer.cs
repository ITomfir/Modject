using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IScreenPointer
{
    event Action<IScreen> OnTransition;
}
