using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private Transform spheresHolderTransform;
    [SerializeField] private Transform spawnPoint;
    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject sphere = (GameObject) Instantiate(Resources.Load("coin Variant"), spawnPoint.position,
                Quaternion.identity, spheresHolderTransform);
            sphere.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 1000);
        }

    }


    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
}
