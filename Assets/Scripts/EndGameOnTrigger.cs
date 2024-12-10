using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameOnTrigger : MonoBehaviour
{

    public GameObject gameOverPanel;
    public GameObject gameOverPanel2;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            gameOverPanel.SetActive(true);
            
            Time.timeScale = 0f;
           
        }
    }
}
