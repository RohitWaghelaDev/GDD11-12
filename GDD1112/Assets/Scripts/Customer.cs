using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

       

        if (other.GetComponent<Vehicle>()!=null)
        {
            other.GetComponent<Vehicle>().GetInfo();
            other.GetComponent<Vehicle>().GetColor();
        }
       
    }
}
