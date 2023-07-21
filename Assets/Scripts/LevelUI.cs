using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    public CurrLevel level;
    public Text text;

    void Update()
    {
        text.text = "Level: " + level.levelNumber.ToString();
    }
}
