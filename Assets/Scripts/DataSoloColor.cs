using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class DataSoloColor : MonoBehaviour, IData
{
    [field: SerializeField] public float RangeAngle { get; set; }
    [field: SerializeField] public GameObject PrafabPartycle { get; set; }
    [field: SerializeField] public RangeData TimeStepSpawn { get; set; }
    [field: SerializeField] public RangeData Speed { get; set; }
    [field: SerializeField] public RangeData TimeLife { get; set; }
    public Material Material;
    [field: SerializeField] public RangeData Size { get; set; }
    public Color Color;


    private void Start()
    {
        Material = Instantiate(Material);
    }

    private void Update()
    {
        Material.color = Color;
    }
}

[Serializable]
public class RangeData
{
    public float Min;
    public float Max;
}
