using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySpawn : IFactorySpawn
{
    private DataMultiColor Data { get; set; }

    public FactorySpawn(DataMultiColor data)
    {
        Data = data;
    }

    public IPartycle SpawnPartycle()
    {
        var partycleGameObject = Object.Instantiate(Data.PrafabPartycle);
        return partycleGameObject.GetComponent<IPartycle>();
    }
}
