using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelHit : ToolHit
{
    public override void Hit()
    {
        Destroy(gameObject);
    }
}
