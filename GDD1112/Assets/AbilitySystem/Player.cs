using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;



    public Transform gunSpawnPoint;
   


    [SerializeField] GameObject pistal;
    [SerializeField] GameObject ak47;
    [SerializeField] GameObject bazooka;

    [SerializeField] float fireratePistal;
    [SerializeField] float fireRateAk47;
    [SerializeField] float fireRateBazzoka;

    [SerializeField] GameObject bulletPistal;
    [SerializeField] GameObject bulletAk47;
    [SerializeField] GameObject bulletBazooka;



    float fireRate;
    float coolDownTime;
    GameObject bullet;
    Transform bulletspawntransform;

    private string currentGunType;

    public GameObject currentGun;

    // Start is called before the first frame update
    void Start()
    {
        coolDownTime = fireRate;
        InitializeGun("pistal");
    }

    // Update is called once per frame
    void Update()
    {

        MovePLayer();


        coolDownTime -= Time.deltaTime;

        if (Input.GetMouseButton(0) && coolDownTime < 0)  {

        

            if (currentGunType == "pistal")
            {
                FirePistal();
            }
            else if (currentGunType == "ak47")
            {

                FireAk47();
            }
            else if (currentGunType == "bazooka")
            {

                FireBazooka();
            }
        }


       

    }


    private void MovePLayer()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }



    void FirePistal() {

        Instantiate(bullet, bulletspawntransform.position, bulletspawntransform.rotation);
        coolDownTime = fireRate;

    }

    void FireAk47()
    {
        Instantiate(bullet, bulletspawntransform.position, bulletspawntransform.rotation);
        coolDownTime = fireRate;
    }


    void FireBazooka()
    {
        Instantiate(bullet, bulletspawntransform.position, bulletspawntransform.rotation);
        coolDownTime = fireRate;
    }


   public  void InitializeGun(string newGun) {

        if (currentGun!=null)
        {
            Destroy(currentGun);
        }

        if (newGun == "pistal")
        {
            GameObject tempGun=  Instantiate(pistal,gunSpawnPoint.position,gunSpawnPoint.rotation);
            bulletspawntransform = tempGun.transform.GetChild(0);
            tempGun.transform.SetParent(gunSpawnPoint.transform);
            currentGun = tempGun;
            fireRate = fireratePistal;
            coolDownTime = fireRate;
            bullet = bulletPistal;
            currentGunType = "pistal";

        }
        else if (newGun == "ak47")
        {

            GameObject tempGun = Instantiate(ak47, gunSpawnPoint.position, gunSpawnPoint.rotation);
            bulletspawntransform = tempGun.transform.GetChild(0);
            tempGun.transform.SetParent(gunSpawnPoint.transform);
            currentGun = tempGun;
            fireRate = fireRateAk47;
            coolDownTime = fireRate;
            bullet = bulletAk47;
            currentGunType = "ak47";
        }
        else if (newGun == "bazooka")
        {

            GameObject tempGun = Instantiate(bazooka, gunSpawnPoint.position, gunSpawnPoint.rotation);
            bulletspawntransform = tempGun.transform.GetChild(0);
            tempGun.transform.SetParent(gunSpawnPoint.transform);
            currentGun = tempGun;
            fireRate = fireRateBazzoka;
            coolDownTime = fireRate;
            bullet = bulletBazooka;
            currentGunType="bazooka";
        }
    }
}
