using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMultiColor : MonoBehaviour
{
    public float RangeAngle;
    public GameObject PrafabPartycle;
    public RangeData TimeStepSpawn;
    public RangeData Speed;
    public RangeData TimeLife;
    public Material OriginalMaterials;
    public Material[] Materials;
    public RangeData Size;
    public Color[] Colors;


    private void Start()
    {
        Materials = new Material[Colors.Length];
        for (int i = 0; i < Colors.Length; i++)
        {
            Materials[i] = Instantiate(OriginalMaterials);            
        }
        
    }

    private void Update()
    {
        for (int i = 0; i < Colors.Length; i++)
        {
            Materials[i].color = Colors[i];
        }
    }
}
