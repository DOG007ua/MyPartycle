using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPartycle
{
    GameObject GameObject { get; }
    void Initialize(IDataPartycle dataPartycle);
    void TimeNow();
    bool IsActive { get; set; }
    event Action<IPartycle> eventActive;
    event Action<IPartycle> eventFinishMove;
}
