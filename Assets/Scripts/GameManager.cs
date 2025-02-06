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
    public TMP_Text CalculatorText;
    public GunController gunController;

    private string textImpact =
        "Der Impuls bereicht sich aus p = m x v. Der Meterorit hat eine Masse m von 100 kg und eine Geschwindigkeit von 0.1 km/h. Wie hoch ist der Impuls? Gebe den Impuls im Taschenrechner ein und überprüfe mich einem Schuss auf dem Meteoriten.";
    
    
    // Start is called before the first frame update
    void Start()
    {
        impactText.text = textImpact;
    }

    // Update is called once per frame
    void Update()
    {
        if (impactMeteorite.isCollided)
        {
            calcImpactMeteorite(impactMeteorite);
        }
    }

    private void calcImpact(Meteorite meteorite, Projectile projectile)
    {
        // ToDo Impulserhaltungssatz
    }

    private void calcImpactMeteorite(Meteorite meteorite)
    {
        double impact = meteorite.speed * meteorite.mass;
        double inputImpact;

        if (double.TryParse(CalculatorText.text, out inputImpact))
        {
            if (Math.Abs(impact - inputImpact) < 0.01) // Tolerance for floating-point errors
            {
                Debug.Log("Der Impuls wurde korrekt berechnet.");
                Destroy(meteorite.gameObject);
            }
            else
            {
                Debug.Log("Falsche Berechnung des Impulses.");
                Debug.Log(inputImpact);
                Debug.Log(impact);
            }
        }
        else
        {
            Debug.Log("Ungültige Eingabe im Taschenrechner.");
        }
        impactMeteorite.isCollided = false;
    }
}
