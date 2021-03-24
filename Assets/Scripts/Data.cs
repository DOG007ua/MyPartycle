using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Data : MonoBehaviour
{
    public float RangeAngle;
    public GameObject PrafabPartycle;
    public RangeData TimeStepSpawn;
    public RangeData Speed;
    public RangeData TimeLife;
    public Material Material;
    public RangeData Size;
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
