using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsPractice : MonoBehaviour
{

    public ForLoopsPlayer player;

    /* Use this script to practice writing for loops
     * 
     * Note:  The player has two methods you can use for practice
     * 
     * player.Shoot()  will fire 1 beet from the wand
     * player.Shoot(GameObject prefab) will shoot a designated object from the wand
     * 
     * player.Message(string message) will change the message on the screen
     * 
     * 
     */

    [Header("Prefabs")]
    public GameObject[] prefabs;



    // Update is called once per frame
    void Update()
    {
       //Test Area
       //Change the method below to check your work

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(CarrotMusketeers());
        }

    }

    public void DemoMethod()
    {
        player.Shoot();
        player.Message("BEET");
    }

    //Example 1: Shoot 3 beets

    IEnumerator ShootThreeBeets()
    {
        for(int i = 0; i < 3; i++)
        {
            player.Shoot();
            yield return new WaitForSeconds(0.2f);
        }
    }

    //Example 2: Shoot one of each vegetable

    IEnumerator ShootAllVeggies()
    {
        for(int i = 0; i < 5; i++)
        {
            player.Shoot(prefabs[i]);
            yield return new WaitForSeconds(0.2f);
        }
    }

    //Example 3: Stay on Beet. Count to 20. Shoot a beet on number divisible by 4.

    IEnumerator StayOnBeet()
    {
        for(int i = 1; i <= 20; i++)
        {
            player.Message(i.ToString());
            if(i % 4 == 0)
            {
                player.Shoot();
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    // Exercise 1: Beet Barrage
    // Task: Use a for loop to shoot 5 beets in a row 

    IEnumerator ShootThemBeets()
    {
        for (int i = 0; i < 5; i++)
        {
            player.Shoot();
            yield return new WaitForSeconds(0.3f);
        }
    }

    // Exercise 2: Count Up Message
    // Task: Use a for loop to display a message that counts from 1 to 5 using player.Message()

    // Exercise 3: Even Number Shooter
    // Task: Use a for loop from 0 to 10. Only shoot a beet when the number is even

    // Exercise 4: Reverse Countdown
    // Task: Count down from 5 to 1 and show each number as a message using player.Message()

    // Exercise 5: Multiple Message Blaster
    // Task: Display the Messages "Ready", "Aim", "Fire", then shoot the vegetable of your choosing.
    // HINT: You will need to create an array of strings in the method for this. LOCAL VARIABLE

    /*IEnumerator ReadyAimFire()
    {
        string[] words = { "Ready", "Aim", "FIRE!" };
    }*/

    // Exercise 6: Summing Loop
    // Task: Sum the numbers from 1 to 10 inside a for loop and display the result using player.Message()

    // Exercise 7: Skip Multiples of 3
    // Task: Use a for loop from 1 to 10. Shoot a carrot unless the number is a multiple of 3

    IEnumerator CarrotMusketeers()
    {
        for (int i = 1; i <= 10; i++)
        {
            player.Message(i.ToString());
            if (i % 3 == 0)
            {
                player.Shoot(prefabs[3]);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    // Exercise 8: Nested Loop Target Practice
    // Task: Shoot 3 beets, then 3 Cabbages, then 3 Broccolis

    // Exercise 9: Fibonacci Display
    // Task: Display the first 6 Fibonacci numbers using player.Message(). For each number, shoot a cabbage (prefabs[2])

    // Exercise 10: Speed Burst
    // Task: Each round, increase the number of shots exponentially (1, 2, 4, 8). Use a different veggie each round from prefabs[0–4], and display how many shots were fired using player.Message()


    // Exercise 11: Pop, Fizz, Bang
    // Task: Count from 1 - 100.
    // If the number is divisible by 2, the message displays the number, then the word Pop and shoots a carrot
    // If the number is divisible by 5, the message displays the number, then the word Fizz and shoots a cauli
    // If the number is divisible by 2 and 5, the message displays the number, then the word BANG and shoots a broccoli

}
