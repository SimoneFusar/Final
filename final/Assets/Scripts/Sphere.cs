using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape {

    // POLYMORPHISM
    public override void MakeSound()
    {
        Debug.Log("Sphere");
    }


}
