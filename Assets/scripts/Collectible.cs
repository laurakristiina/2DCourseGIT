using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject particlePrefab;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player")
        {
            Instantiate(particlePrefab, transform.position, Quaternion.identity);
            Cottontracker._instance.AddScore();
            gameObject.SetActive(false);
        }
    }
}
