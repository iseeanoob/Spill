using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  Killer_cube: MonoBehaviour
{
    public int Respawn;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("level 1");
        }
    }
}
