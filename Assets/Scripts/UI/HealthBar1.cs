using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar1 : MonoBehaviour
{
	public PlayerHealth PlayerHealth;
	public Slider slider;

	void Start()
    {
        slider.maxValue = PlayerHealth.health;
	}

	// Update is called once per frame
	void Update()
    {
		slider.value = PlayerHealth.health;
    }
}
