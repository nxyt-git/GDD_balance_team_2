using System;
using UnityEditor.AssetImporters;
using UnityEngine;

public class PlayerLevelProgress : MonoBehaviour
{
    /// <summary>
    /// Zarzadzanie zbieraniem srubek
    /// </summary>
    [SerializeField] private int collectedScrew = 0;
    [SerializeField]private const int REQUIRED_SCREW = 5;

    public event Action OnRequiredScrewCollected;
    public int CollectedScrew => collectedScrew;

 
    public void AddScore()
    {
        if (energyLevel == MaxEnergy)
        {
            collectedScrew++;
            Debug.Log("Screw collected: " + collectedScrew);

            if (collectedScrew >= REQUIRED_SCREW)
            {
                OnRequiredScrewCollected?.Invoke();
            }
        }
        else if(energyLevel < MaxEnergy)
        {
            Debug.Log("Za niski poziom energi");
        }
    }

    //Zarzadzanie poziomem naladowania
    [SerializeField] private int energyLevel = 0;
    [SerializeField] private const int MaxEnergy = 100;

    public int EnergyLevel => energyLevel;
    public int MaxEnergyLevel => MaxEnergy;
    

    
    public void LoadEnergy()
    {
        if(energyLevel < MaxEnergy)
        {
            energyLevel++;
            Debug.Log("Poziom energi wzrasta: " + energyLevel);

        }
    }
    //Rozladowanie po wejsciu w kalurze
    public void DropEnergy()
    {
        energyLevel = 0;
        Debug.Log("Poziom energi spada: " + energyLevel);
    }

}
