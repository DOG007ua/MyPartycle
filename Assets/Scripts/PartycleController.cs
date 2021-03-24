using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartycleController : MonoBehaviour
{    
    private IFactorySpawn factory;
    private ISpawner spawner;
    private IObjectPool objectPool;
    [SerializeField] private Transform dataTransform;
    [SerializeField] private IData data;
    [SerializeField] private Transform poolPartycleParent;
    [SerializeField] private Transform movePartycleParent;

    void Start()
    {
        data = dataTransform.GetComponent<IData>();
        factory = new FactorySpawn(data);        
        objectPool = new ObjectPool(factory, poolPartycleParent);
        spawner = new SpawnerMultiColor(objectPool, data, movePartycleParent);
    }

    // Update is called once per frame
    void Update()
    {
        spawner.Update();
    }
}
