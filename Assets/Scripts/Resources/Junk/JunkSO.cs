using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Junk", menuName = "SO/Junk")]
public class JunkSO : ScriptableObject
{
    protected string junkName = "Junk";
    public int hpMax = 2;
    public List<DropRate> dropList;
}
