using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    public int cupsInTheSink;


    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}
