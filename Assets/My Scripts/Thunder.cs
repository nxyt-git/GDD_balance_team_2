using UnityEngine;

public class Thunder : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.TryGetComponent<PlayerLevelProgress>(out var playerLevelProgress))
            {
                playerLevelProgress.LoadEnergy();
            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {

    //        if (other.TryGetComponent<PlayerLevelProgress>(out var playerLevelProgress))
    //        {
    //            playerLevelProgress.AddScore();
    //            Destroy(gameObject);
    //        }
    //    }
    //}


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.5f);
    }
}
