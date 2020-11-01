using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{
    // variables
    public GameObject slicedApple;
    public GameObject slicedBanana;
    public GameObject slicedKiwi;
    public GameObject slicedStrawberry;
    public GameObject youAreReadyText;
    public AudioSource growl;


    public TextMesh scoreText;
    private int score = 0;
    public AudioSource slashSource;
  


    // Start is called before the first frame update
    void Start()
    {
        slashSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "SLICED" )
        {
          

            // play slash audio
            slashSource.Play();

            string fruitNameIHit = collision.gameObject.name;

            // Check Name is fruit name, Show Sliced Fruit


            if (fruitNameIHit.Contains("Apple"))
                showSlicedFruit(slicedApple, collision.gameObject);

            if (fruitNameIHit.Contains("Banana"))
                showSlicedFruit(slicedBanana, collision.gameObject);

            if (fruitNameIHit.Contains("Kiwi"))
                showSlicedFruit(slicedKiwi, collision.gameObject);

            if (fruitNameIHit.Contains("Strawberry"))
                showSlicedFruit(slicedStrawberry, collision.gameObject);
        }
      
    }
    void showSlicedFruit(GameObject slicedFruitToShow, GameObject wholeFruitToDelete)
    {
        GameObject slicedFruit = Instantiate(slicedFruitToShow, wholeFruitToDelete.transform.position,
            wholeFruitToDelete.transform.rotation);

        slicedFruit.gameObject.name = "SLICED";

        Destroy(wholeFruitToDelete);

        score++;
        scoreText.text = "SCORE: " + score;

        if (score > 100)
            showYouAreReady();
    }

   void showYouAreReady()
    {
        Instantiate(youAreReadyText);


    }
}
