using UnityEngine;

public class FinishScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] private GameObject levelCompleteText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Poziom ukończono");

            if (levelCompleteText != null)
                levelCompleteText.SetActive(true);
        }
    }
}
