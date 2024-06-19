using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGateTrigger : MonoBehaviour
{
    public GameObject levelWon;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Green"))
        {
            levelWon.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
