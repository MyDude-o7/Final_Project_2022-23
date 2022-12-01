using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectilePrefab = null;
    public Transform startPoint = null;
    public float launchSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);

            if (newObject.TryGetComponent(out Rigidbody rigidBody))
                ApplyForce(rigidBody);
        }

    }

    private void ApplyForce(Rigidbody rigidBody)
    {
        Vector3 force = startPoint.forward * launchSpeed;
        rigidBody.AddForce(force);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
