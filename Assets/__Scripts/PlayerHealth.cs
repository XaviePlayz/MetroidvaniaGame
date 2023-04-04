using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float hitPoints;
    public float maxHitPoints = 100;
    public PlayerHealthBarBehaviour Healthbar;
    public GameObject gameOverScreen;
    public Transform canvas;


    private void Start()
    {
        hitPoints = maxHitPoints;
        Healthbar.SetPlayerHealth(hitPoints, maxHitPoints);
    }

    public void UpdateHealth(float damage)
    {
        hitPoints -= damage;
        Healthbar.SetPlayerHealth(hitPoints, maxHitPoints);

        if (hitPoints <= 0)
        {
            gameOverScreen.SetActive(true);
            //Instantiate(gameOverScreen, canvas, true);
        }
    }
}
