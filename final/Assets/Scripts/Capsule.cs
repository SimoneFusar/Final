using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Capsule : Shape {

    // POLYMORPHISM
    public override void MakeSound()
    {
        Debug.Log("Capsule");
    }


}
