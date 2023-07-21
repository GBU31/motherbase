using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public CurrLevel curr;
    public float initialIncreaseInterval = 120f;
    private float increaseInterval;
    public int points = 5;
    private Coroutine levelIncreaseCoroutine;

    public void Start()
    {
        increaseInterval = initialIncreaseInterval;
        levelIncreaseCoroutine = StartCoroutine(IncreaseLevelOverTime());
    }

    private IEnumerator IncreaseLevelOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(increaseInterval);
            curr.points = curr.points + points;

        }
    }

   
}
