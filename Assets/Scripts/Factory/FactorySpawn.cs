using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySpawn : IFactorySpawn
{
    private Data Data { get; set; }

    public FactorySpawn(Data data)
    {
        Data = data;
    }

    public IPartycle SpawnPartycle()
    {
        var partycleGameObject = Object.Instantiate(Data.PrafabPartycle);
        return partycleGameObject.GetComponent<IPartycle>();
    }
}
