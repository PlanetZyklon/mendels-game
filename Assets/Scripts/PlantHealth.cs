using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlantHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public float currentHydration;

    public float currentNutrition;

    public RectTransform healthbar;
    public RectTransform waterbar;
    public RectTransform nutritionbar;

    private Camera cam;
    public GameObject plantPrefab;

    // canvas
    public GameObject plantStatsMenu;

    void Start()
    {
        plantStatsMenu.SetActive(false);
        cam = Camera.main;
    }

    public void setHealthValue(float amount)
    {
        currentHealth += amount;
        if (currentHealth < 0)
            currentHealth = 0;
        //Debug.Log(currentHealth);
        
        healthbar.sizeDelta = new Vector2(currentHealth * 4, healthbar.sizeDelta.y);
    }

    public void setWaterValue(float amount)
    {
        currentHydration += amount;
        if (currentHydration < 0)
            currentHydration = 0;
        //Debug.Log(currentHydration);

        waterbar.sizeDelta = new Vector2(currentHydration * 4, waterbar.sizeDelta.y);
    }

    public void setNutritionValue(float amount)
    {
        currentNutrition += amount;
        if (currentNutrition < 0)
            currentNutrition = 0;
        //Debug.Log(currentNutrition);

        nutritionbar.sizeDelta = new Vector2(currentNutrition * 4, nutritionbar.sizeDelta.y);
    }

    public void Update()
    {
        setHealthValue(-0.01f);
        setWaterValue(-0.005f);
        setNutritionValue(-0.007f);

        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        var distance = Vector3.Distance(mousePos, plantPrefab.transform.position);

        // checks the distance between the mouse and the prefab
        // if it's less than 2.1 units, the UI's visible
        if (distance < 2.1)
        {
            plantStatsMenu.SetActive(true);
        }
        else
        {
            plantStatsMenu.SetActive(false);
        }
    }
}
