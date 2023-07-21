using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "Level/Create New Level")]
public class Level : ScriptableObject
{
    public int levelNumber = 0;
    public Item item;
    public int points = 0;
}
