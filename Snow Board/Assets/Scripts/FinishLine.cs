using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private float resetTime = 1.5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("ResetLevel", resetTime);
        }
    }
    void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
