using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUps : MonoBehaviour
{
    public AudioSource audio;
    public GameObject player;
    public PowerUpCounter pou;


    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        audio.Play();
        Destroy(gameObject);

        if (other.gameObject.tag == "Player")
        {
            pou.increment();
            
            
        }

    }
}
