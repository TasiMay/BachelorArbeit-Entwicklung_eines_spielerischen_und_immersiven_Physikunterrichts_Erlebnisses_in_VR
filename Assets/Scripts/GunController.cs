using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Rigidbody projectile;
    public float velocity = -50;

    public GameObject FireOrigin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        Rigidbody clone = Instantiate (projectile, FireOrigin.transform.position, FireOrigin.transform.rotation);
        clone.velocity = transform.TransformDirection(new Vector3(velocity, 0, 0));
        Destroy (clone.gameObject, 3f);
    }
}
