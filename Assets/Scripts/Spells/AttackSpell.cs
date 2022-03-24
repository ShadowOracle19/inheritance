using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType
{
    fire,
    bleed,
    holy,
    curse,
    magic
}

public class AttackSpell : SpellBase
{
    public int damage;
    public DamageType type;
}
