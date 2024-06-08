using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trap : MonoBehaviour
{

    public Slider healthBar;
    public float damageAmount = 0.01f;
    // Start is called before the first frame update
    private void onTriggerEnter2D(Collider2D  collision) 
    {
      float value = healthBar.value;
        value -= damageAmount; 

        healthBar.value = value;

    }   
}
