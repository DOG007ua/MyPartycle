using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IData
{
    float RangeAngle { get; set; }
    GameObject PrafabPartycle { get; set; }
    RangeData TimeStepSpawn { get; set; }
    RangeData Speed { get; set; }
    RangeData TimeLife { get; set; }
    RangeData Size { get; set; }
}
