using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PinkGateTrigger : MonoBehaviour
{
    public GameObject levelWon;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Pink"))
        {
            levelWon.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
