using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectPool
{
    IPartycle GetPartycle();
    void AddToList(IPartycle partycle);

}
