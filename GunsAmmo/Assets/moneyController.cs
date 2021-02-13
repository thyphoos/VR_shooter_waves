using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyController : MonoBehaviour
{
    [SerializeField] private Transform spheresHolderTransform;
    [SerializeField] private Transform launchPoint;
    private void Shoot()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject sphere = (GameObject) Instantiate(Resources.Load("money Variant"), launchPoint.position,
                Quaternion.Euler(270,90,0), spheresHolderTransform);
            sphere.GetComponent<Rigidbody>().AddForce(launchPoint.right * 1000);
        }

    }


    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    // Update is called once per frame
   
}
