using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Shape : MonoBehaviour
{
    // POLYMORPHISM
    public virtual void MakeSound()
    {
        Debug.Log("No sound Detected");
    }

    void Start()
    {
        MakeSound();
    }

    void Update()
    {
        
    }
}
