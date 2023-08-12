using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]
    private float resetTime = 1.5f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            Invoke("ResetLevel", resetTime);
        }
    }
    void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
