using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectNotes : MonoBehaviour
{
    public AudioSource collectSound;
     void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.score += 1;

       
    }
     void OnTriggerExit(Collider other)
    {
        gameObject.SetActive(false);
    }
}
