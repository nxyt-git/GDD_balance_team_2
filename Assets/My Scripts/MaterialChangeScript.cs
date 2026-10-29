using UnityEngine;

public class MaterialChangeScript : MonoBehaviour
{

    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private Material normalMaterial;
    [SerializeField] private Material chargedMaterial;
    private PlayerLevelProgress progress;
    private bool isCharged;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (meshRenderer == null) meshRenderer = GetComponent<MeshRenderer>();
        progress = GetComponent<PlayerLevelProgress>();

        meshRenderer.sharedMaterial = normalMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        bool full = progress.EnergyLevel >= progress.MaxEnergyLevel;

        if (full != isCharged)
        {
            isCharged = full;
            meshRenderer.sharedMaterial = isCharged ? chargedMaterial : normalMaterial;
        }
    }
}
