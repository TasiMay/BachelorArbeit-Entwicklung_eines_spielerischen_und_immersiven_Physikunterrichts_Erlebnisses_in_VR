using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public float speed = 0f;
    public double mass = 0;
    public bool isCollided = false;
    private Projectile projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            projectile= collision.gameObject.GetComponent<Projectile>();
            isCollided = true;
        }
    }
    
}
