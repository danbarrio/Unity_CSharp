using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour
{
    public int myInt = 5;
    public int multValue = 1;
    int result;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            result = MultiplyByValue(myInt);
            Debug.Log("Result = " + result);
        }
    }

    int MultiplyByValue(int number)
    {
        int returnValue;
        returnValue = number * multValue;
        return returnValue;
    }


    /*
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }


    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }

    */

}