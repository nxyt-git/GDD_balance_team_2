using System;
using TMPro;
using UnityEngine;

public class Unload_Zone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private PlayerLevelProgress playerProgress;
    public bool LevelCompleted = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (other.TryGetComponent<PlayerLevelProgress>(out var playerLevelProgress) && playerLevelProgress.CollectedScrew >= playerLevelProgress.Requider_Screw)
            {
                LevelCompleted = true;
                Debug.Log("Poziom ukonczono");
            }
        }
    }

}
