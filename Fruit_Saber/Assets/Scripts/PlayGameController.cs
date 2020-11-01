using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayGameController : MonoBehaviour
{
    //fruit variables 
    public GameObject fruitContainer;
    Fruit[] fruits;
    Fruit fruitthrowing;

    private int frames = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Get fruit form container 
        fruits = fruitContainer.GetComponentsInChildren<Fruit>();
        
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        if (frames % 10 == 0)
        { //If the remainder of the current frame divided by 10 is 0 run the function.
           
            fruitthrowing = fruits[Random.Range(0, fruits.Length)];
            fruitthrowing.transform.position = transform.position;
            fruitthrowing.showWholeFruit();
        }
    }
}
