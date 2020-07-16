using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<PlayerMove>().PlayWin();
        other.GetComponent<PlayerMove>().enabled = false;
        FindObjectOfType<GameManager>().Win();
    }
}
