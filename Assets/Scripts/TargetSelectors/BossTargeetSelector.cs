﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BossTargeetSelector : TargetSelector
{
    public override List<Targettable> GetTargetsInRange(Vector3 position, float radius)
    {

        return EntityManager.Instance
          .GetTargetsInRadius(position, radius, EntityType.Enemy)
          .OrderBy(item => item.healthComponent.maxHelth).ToList();

    }
}
