using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPartycle
{
    float Speed { get; set; }
    float TimeLife { get; set; }

    Material Material { get; set; }
    Color Color { get; set; }
}
