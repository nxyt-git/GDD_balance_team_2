using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0.5f,0.5f);
    }

    //TODO: sprawic aby ta metoda dodawala punkty zebranych srubek graczowi
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (other.TryGetComponent<PlayerLevelProgress>(out var playerLevelProgress))
            {
                playerLevelProgress.AddScore();
                Destroy(gameObject);
            }
        }
    }
}
