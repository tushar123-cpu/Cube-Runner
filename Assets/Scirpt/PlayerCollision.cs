using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScirpt playerScirpt;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            score.Addscore(1);
            Destroy(other.gameObject);
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstactles")
        {
            audioSource1.Play();
            gameController.GameOver();
            playerScirpt.enabled = false;
        }
    }
}
