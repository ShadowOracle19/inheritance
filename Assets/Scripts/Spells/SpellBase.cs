using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBase : MonoBehaviour
{
    public string name;
    public int manaCost;

    public virtual void CastSpell()
    {
        Debug.Log("Spell Cast");
    }

}
