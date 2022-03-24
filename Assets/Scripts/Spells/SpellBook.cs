using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBook : MonoBehaviour
{
    public List<AttackSpell> attackSpells = new List<AttackSpell>();

    public void CastSpellFromBook()
    {
        attackSpells[1].CastSpell();
    }
}

