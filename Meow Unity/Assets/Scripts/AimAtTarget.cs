using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAtTarget : MonoBehaviour
{
    public GameObject target;
    public float aimingSpeed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDirection = target.transform.position - transform.position; 

        float singleStep = aimingSpeed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward,
         targetDirection, singleStep, 0.0f);

        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
