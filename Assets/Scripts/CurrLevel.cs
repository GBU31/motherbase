using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CurrentLevel", menuName = "Current Level/Create New Level")]
public class CurrLevel : ScriptableObject
{
    public int levelNumber = 0;
    public int points = 0;
}
