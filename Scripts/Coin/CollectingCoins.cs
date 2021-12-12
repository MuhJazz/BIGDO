using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public AudioSource Soundnya;

    void OnTriggerEnter(Collider other)
    {
        Soundnya.Play();
        ScoringSystem.scorenya += 1;
        Destroy(gameObject);
    }
}
