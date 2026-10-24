using System;
using UnityEditor.AssetImporters;
using UnityEngine;

public class PlayerLevelProgress : MonoBehaviour
{
    
    [SerializeField] private int collectedScrew = 0;
    [SerializeField]private const int REQUIRED_SCREW = 5;

    public event Action OnRequiredScrewCollected;
    public int CollectedScrew => collectedScrew;
    public int RequiredScrew => REQUIRED_SCREW;

    public void AddScore()
    {
        collectedScrew++;

        Debug.Log("Screw collected: " + collectedScrew);
        
        if (collectedScrew >= REQUIRED_SCREW)
        {
            OnRequiredScrewCollected?.Invoke();
        }
    }
}
