using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int pages;
    public Enemy enemy;
    public AudioClip scarySound;
    public FirstPersonMovement sped;

    private void OnTriggerEnter(Collider other)
    {
        print("You found the page");
        Destroy(other.gameObject);
        pages++;

        if (pages ==1)
        {
            
            enemy.target = transform;
        }

        if (pages==2)
        {
            enemy.speed *= 2;
        }

        if (pages == 3)
        {
            enemy.viewDistance =  20;
            enemy.speed += 1;
        }

        if (pages == 4)
        {
            
            var source = GetComponent<AudioSource>();
            source.clip = scarySound;
            source.Play();
            
        }
        if (pages == 5)
        {
            sped.speed = 3;
        }
    }
}
