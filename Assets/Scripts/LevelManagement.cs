using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagement: MonoBehaviour
{
    public CurrLevel curr;
    public List<Level> levelslist = new List<Level>();

    public void Update()
    {
        foreach (var level in levelslist)
        {

            if (curr.points <= level.points)
            {
                Debug.Log(level.levelNumber.ToString());
                curr.levelNumber = level.levelNumber;
            }

            if (curr.points >= level.points)
            {
                if (Is_obj_in_lst(level.item) != true && level.item)
                {
                    Debug.Log(curr.points == level.points);
                    InventoryManager.Instance.Add(level.item);
                }

            }

        }


    }

    public bool Is_obj_in_lst(Item ITem)
    {

        foreach (var item in InventoryManager.Instance.Items)
        {
            if (ITem == item)
            {
                return true;
            }
            

        }
        return false;
    }
}