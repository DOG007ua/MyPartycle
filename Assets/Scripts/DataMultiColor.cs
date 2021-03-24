using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMultiColor : MonoBehaviour, IData
{
    [field: SerializeField]public float RangeAngle { get; set; }
    [field: SerializeField] public GameObject PrafabPartycle { get; set; }
    [field: SerializeField] public RangeData TimeStepSpawn { get; set; }
    [field: SerializeField] public RangeData Speed { get; set; }
    [field: SerializeField] public RangeData TimeLife { get; set; }
    public Material OriginalMaterials;
    public Material[] Materials;
    [field: SerializeField] public RangeData Size { get; set; }
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
