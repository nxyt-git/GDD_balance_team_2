using System;
using UnityEngine;

public class Finish_Point : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    [SerializeField] private float riseSpeed = 5f;
    // Update is called once per frame
    private bool done;

    void Update()
    {
        if (!IsLevelCompleted || done ) return;

        transform.position += Vector3.up * 5.0f;
        done = true;    
    }
    [SerializeField] private Unload_Zone unloaded;
    private bool IsLevelCompleted => unloaded != null && unloaded.LevelCompleted;

}
