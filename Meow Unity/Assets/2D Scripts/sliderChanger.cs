using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider changer; 
    void Start()
    {
        changer = GetComponent<Slider>();
    }

    // Update is called once per frame
    public void ChangeValue(float incremement )
    {
        changer.value +=  incremement;
    }
}
