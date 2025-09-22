using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAction : AIAction
{
    public override void TakeAction()
    {
        enemyBrain.Move(enemyBrain.playerTrm.position);
    }
}
