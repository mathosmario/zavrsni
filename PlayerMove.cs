using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    AudioSource source;
    public AudioClip[] clip;
    public float speed = 10;
    public float forwardSpeed = 15;
    bool startGame = false;
    bool left = false;
    bool right = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();

    }
    public void PlayGameOver()
    {
        source.PlayOneShot(clip[0]);
    }
    public void PlayWin()
    {
        source.PlayOneShot(clip[1]);
    }
    void Update()
    {
        if (Input.anyKey)
            startGame = true;
        if (startGame == true)
            rb.velocity = new Vector3(0, rb.velocity.y, forwardSpeed);
        if (Input.GetKey(KeyCode.A))
            left = true;
        else if (Input.GetKey(KeyCode.D))
            right = true;
        if (Input.GetKeyUp(KeyCode.A))
            left = false;
        if (Input.GetKeyUp(KeyCode.D))
            right = false;
        if (transform.position.y < -5)
            FindObjectOfType<GameManager>().Restart();
    }
    private void FixedUpdate()
    {
        if (left == true)
            rb.velocity = new Vector3(-speed, rb.velocity.y, forwardSpeed);
        else if (right == true)
            rb.velocity = new Vector3(speed, rb.velocity.y, forwardSpeed);

    }
}
