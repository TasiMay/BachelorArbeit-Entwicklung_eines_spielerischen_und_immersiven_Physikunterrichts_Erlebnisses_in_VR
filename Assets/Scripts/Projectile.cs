using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0f;
    public double mass = 0;

    public Vector3 direction = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }

    public void setMass(double mass)
    {
        this.mass = mass;
    }
}