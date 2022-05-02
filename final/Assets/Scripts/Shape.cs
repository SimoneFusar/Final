using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE 
// ABSTRACTION
public class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public string Name;
    public string Color;


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
