using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas ui;
    public List<Meteorite> meteorites; // ToDo For different types of meteorites
    public Meteorite impactMeteorite;
    public TMP_Text impactText;
    public TMP_Text CalculatorText;
    public Canvas feedbackUI;
    public TMP_Text feedbackText;

    private string textImpact =
        "Der Impuls bereicht sich aus p = m x v. Der Meterorit hat eine Masse m von 100 kg und eine Geschwindigkeit von 0.1 km/h. Wie hoch ist der Impuls? Gebe den Impuls im Taschenrechner ein und überprüfe mich einem Schuss auf dem Meteoriten.";
    
    
    // Start is called before the first frame update
    void Start()
    {
        feedbackUI.gameObject.SetActive(false);
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
    } // ToDo calculation for Level 2-4

    private void calcImpactMeteorite(Meteorite meteorite)
    {
        double impact = meteorite.speed * meteorite.mass;
        double inputImpact;

        if (double.TryParse(CalculatorText.text, out inputImpact))
        {
            if (Math.Abs(impact - inputImpact) < 0.01) // Tolerance for floating-point errors
            {
                Destroy(meteorite.gameObject);
                feedbackText.text = "Gut gemacht!";
            }
            else
            {
                feedbackText.text = "Die Berechnung war nicht korrekt.";
            }

        }
        else
        {
            feedbackText.text = "Ungültige Eingabe im Taschenrechner.";
        }
        
        impactMeteorite.isCollided = false;
        feedbackUI.gameObject.SetActive(true);
        StartCoroutine(HideFeedbackAfterDelay(3f));
    }

    private IEnumerator HideFeedbackAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        feedbackUI.gameObject.SetActive(false);
    }
}
