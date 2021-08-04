using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text scoreLabel, velocityLabel;

    public void setValues(float distanceTraveled, float velocity)
    {
        scoreLabel.text = ((int)(distanceTraveled * 10f)).ToString();
        velocityLabel.text = ((int)(velocity * 10f)).ToString();
    }
}
