using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<PlayerMove>().PlayGameOver();
            collision.collider.GetComponent<PlayerMove>().enabled = false ;
            collision.collider.GetComponent<Animator>().SetTrigger("Start");
            FindObjectOfType<GameManager>().EndScreen();
        }
    }
}
