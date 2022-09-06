using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRun : BaseMove
{
    public override void Move(Vector3 direction)
    {
        mover.velocity = direction * moveSpeed;

    }

}
