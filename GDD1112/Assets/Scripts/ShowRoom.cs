using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRoom : MonoBehaviour
{
   

    public Vehicle[] vehicles;




 


    // Start is called before the first frame update
    void Start()
    {

        //vehicle.PrintType();
      // car.PrintType();


        for (int i = 0; i < vehicles.Length; i++)
        {
            vehicles[i].PrintType();
        }


    }




}
