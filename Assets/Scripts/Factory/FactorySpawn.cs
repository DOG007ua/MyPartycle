using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySpawn : IFactorySpawn
{
    private IData Data { get; set; }

    public FactorySpawn(IData data)
    {
        Data = data;
    }

    public IPartycle SpawnPartycle()
    {
        var partycleGameObject = Object.Instantiate(Data.PrafabPartycle);
        return partycleGameObject.GetComponent<IPartycle>();
    }
}
