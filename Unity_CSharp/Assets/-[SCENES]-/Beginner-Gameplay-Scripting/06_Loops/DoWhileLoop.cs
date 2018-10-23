using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour
{
    // while loops always run the code in _do_ section THEN check the condition in _while_ section to see if should run again
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);
    }
}