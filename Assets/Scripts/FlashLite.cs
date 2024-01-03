using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLite : MonoBehaviour
{
  public bool isOn;
  public Light light;
  public AudioClip click;
  public int hp;

    private void Update()
    {
        light.enabled = isOn;

        if(Input.GetKeyDown(KeyCode.E))
        {
            Switch();
        }

        if(isOn = true)
        {
            Invoke("Hp", 10f);
        }

       
    }
    void Hp()
    {
        hp -= 1;
    }

    void Switch()
    {
        isOn = !isOn;
        var source = GetComponent<AudioSource>();
        source.clip = click;
        source.Play();
    }

   
}
