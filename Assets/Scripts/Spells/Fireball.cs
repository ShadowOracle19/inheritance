using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : AttackSpell
{
    public override void CastSpell()
    {
        fireball();
    }

    void fireball()
    {
        Debug.Log("FIREBALL!");
    }
}
