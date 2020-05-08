using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public string gunPickUpName;


    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();

        if (player !=null)
        {

            player.InitializeGun(gunPickUpName);
            Destroy(gameObject);
        }
    }
}
