using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create a custom struct and apply [Serializable] attribute to it
[Serializable]
public struct CosmoEscalaItemData
//: MonoBehaviour
//: ScriptableObject
{
    public double numerator;
    public double denominator;

    public double Calc(double valor)
    {
        return valor * numerator / denominator;
    }
}
