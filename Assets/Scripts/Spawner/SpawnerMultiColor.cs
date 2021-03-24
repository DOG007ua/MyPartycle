using UnityEngine;

class SpawnerMultiColor : ISpawner
{
    private DataMultiColor Data { get; set; }
    private IObjectPool objectPool;
    private float timeNow = 0;
    private Transform parentMovePartycle;
    private float timeSpawn = 0;

    public SpawnerMultiColor(IObjectPool objectPool, IData Data, Transform parentMovePartycle)
    {
        this.Data = Data as DataMultiColor;
        this.objectPool = objectPool;
        this.parentMovePartycle = parentMovePartycle;
        timeSpawn = SetRandomTimeSpawn();
    }

    public void Update()
    {
        timeNow += Time.deltaTime;
        Timer();
    }

    public void SpawnPartycle()
    {
        var partycle = objectPool.GetPartycle();

        partycle.Initialize(UpdateDataPartycle());
        partycle.GameObject.transform.SetParent(parentMovePartycle);
        UpdatePartycleTransform(partycle);
        partycle.IsActive = true;
    }

    private DataPartycle UpdateDataPartycle()
    {
        DataPartycle data = new DataPartycle();
        data.Material = Data.Materials[Random.Range(0, Data.Materials.Length)];
        data.Speed = Random.Range(Data.Speed.Min, Data.Speed.Max);
        data.TimeLife = Random.Range(Data.TimeLife.Min, Data.TimeLife.Max);
        return data;
    }

    private void UpdatePartycleTransform(IPartycle partycle)
    {
        var scale = Random.Range(Data.Size.Min, Data.Size.Max);
        partycle.GameObject.transform.eulerAngles = VectorDirectionMove();
        partycle.GameObject.transform.localPosition = new Vector3(0, 0, 0);
        partycle.GameObject.transform.localScale = new Vector3(scale, scale, scale);
    }

    private Vector3 VectorDirectionMove()
    {
        var angleX = Random.Range(-Data.RangeAngle, Data.RangeAngle) - 90;
        var angleZ = Random.Range(-Data.RangeAngle, Data.RangeAngle);
        return new Vector3(angleX, angleZ, 0);
    }

    public void Timer()
    {
        if (timeNow > timeSpawn)
        {
            timeNow = 0;
            timeSpawn = SetRandomTimeSpawn();
            SpawnPartycle();
        }
    }

    private float SetRandomTimeSpawn()
    {
        return Random.Range(Data.TimeStepSpawn.Min, Data.TimeStepSpawn.Max);
    }
}