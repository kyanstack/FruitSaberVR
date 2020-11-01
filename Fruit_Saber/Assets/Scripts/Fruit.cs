using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fruit : MonoBehaviour
{
    // fruit variables \
    public GameObject wholeFruit;
    GameObject fruitThrowing;

    // Push Fruit Force Variables
    public float minVerticleForce = 50;
    public float maxVerticleForce = 200;
    public float minHorizontalForce = 50;
    public float maxHorizontalForce = 200;
    float verticleForce;
    float horizontalForce;
    float throwingDirection = 1;



    // Start is called before the first frame update
    void Start()
    {
        // set forces
        verticleForce = Random.Range(minVerticleForce, maxVerticleForce);
        horizontalForce = Random.Range(minHorizontalForce, maxHorizontalForce);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showWholeFruit()
    {
        fruitThrowing = Instantiate(wholeFruit);

        fruitThrowing.transform.position = transform.position;

        setThrowingDirection();

        fruitThrowing.GetComponent<Rigidbody>().AddForce(
            new Vector3(
                horizontalForce * throwingDirection,
                verticleForce,
                0
            )
            );
    }

    void setThrowingDirection()
    {
        if (Random.value > 0.5)
            throwingDirection = 1;
        else
            throwingDirection = -1;

    }
}
