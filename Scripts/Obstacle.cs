using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float FallSpeed;
    [SerializeField] public int Damage;
    //[SerializeField] public Vector2 SpawnFreq { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //fall down
        transform.position += Vector3.down * FallSpeed * Time.deltaTime;
    }
}
