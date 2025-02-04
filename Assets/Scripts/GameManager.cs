using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas ui;
    public List<Meteorite> meteorites;
    public Meteorite impactMeteorite;
    public TMP_Text impactText;
    public GunController gunController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gunController.Fire();
        }

        if (typeof(Collision).IsAssignableFrom(typeof(Meteorite)) &&
            typeof(Collision).IsAssignableFrom(typeof(Projectile)))
        {
            // ToDo add finding of Meteorite and Projectile
        }
        
    }

    private void calcImpact(Meteorite meteorite, Projectile projectile)
    {
        // ToDo Impulserhaltungssatz
    }

    private void calcImpactMeteorite(Meteorite meteorite, string impactText)
    {
        var impact = meteorite.speed * meteorite.mass;
        var inputImpact = Convert.ToDouble(impactText);

        if (impact == inputImpact)
        {
            Console.WriteLine("Der Impuls wurde korrekt berechnet.");
        }
    }
}
