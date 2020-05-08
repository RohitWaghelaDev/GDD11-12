using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{


    public string vehicleType;
    public string companyName;
    public string color;

    public void PrintType()
    {
        Debug.Log("i am " + vehicleType+"my company is: "+companyName);
    }


public void GetInfo() {

        Debug.Log("vehicle Type " + vehicleType + " my company is: " + companyName);

    }


    public void GetColor() {


        Debug.Log("my color is " + color);
    }


 //   public abstract void Run();
}
