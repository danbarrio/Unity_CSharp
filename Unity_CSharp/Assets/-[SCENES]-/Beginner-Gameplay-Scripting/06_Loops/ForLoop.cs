using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
    public int numEnemies;

    // for loop conditional syntax: (initialize count variable; condition to run loop; increment or decrement value)
    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}