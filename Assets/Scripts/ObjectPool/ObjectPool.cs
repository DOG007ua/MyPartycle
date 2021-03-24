using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool : IObjectPool
{
    private List<IPartycle> listPartycles { get; }
    private IFactorySpawn factory { get; }
    private Transform parentPoolPartycle;

    public ObjectPool(IFactorySpawn factory, Transform parentPoolPartycle)
    {
        this.factory = factory;
        this.parentPoolPartycle = parentPoolPartycle;
        listPartycles = new List<IPartycle>();
    }

    public IPartycle GetPartycle()
    {
        return listPartycles.Count > 0 ? ReturnPartycleList() : CreateNewPartycle();
    }    

    private IPartycle ReturnPartycleList()
    {
        var partycle = listPartycles.Last();
        listPartycles.Remove(partycle);
        return partycle;
    }

    private IPartycle CreateNewPartycle()
    {
        var partycle = factory.SpawnPartycle();
        partycle.eventFinishMove += PartycleFinishMove;
        return partycle;
    }

    private void PartycleFinishMove(IPartycle partycle)
    {
        partycle.IsActive = false;
        AddToList(partycle);
    }

    public void AddToList(IPartycle partycle)
    {
        listPartycles.Add(partycle);
        partycle.GameObject.transform.SetParent(parentPoolPartycle);
    }
}
