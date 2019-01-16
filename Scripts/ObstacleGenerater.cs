using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerater : MonoBehaviour
{
    [SerializeField] private float InitFreq;
    [SerializeField] private float MaxFreq;
    //[SerializeField] private float FreqRandPerc;
    [SerializeField] private GameObject[] Obstacles;
    [SerializeField] private Vector2 SpawnBound;

    public float CurrentFreq;
    public float Freqtimer;
    private float SpawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        CurrentFreq = InitFreq;
    }

    // Update is called once per frame
    void Update()
    {
        Freqtimer += Time.deltaTime; 
        if (CurrentFreq < MaxFreq && Freqtimer >= 10*CurrentFreq){ 
            CurrentFreq += 0.1f;
            Freqtimer = 0;
            if (Freqtimer >= MaxFreq) {
                Freqtimer = MaxFreq;
            }
        }
        // Spawn something
        SpawnTimer += Time.deltaTime;
        if (SpawnTimer > 1/CurrentFreq) {
            Vector3 SpawnPos = new Vector3(Random.Range(SpawnBound.x, SpawnBound.y), transform.position.y, transform.position.z);
            Instantiate(Obstacles[Random.Range(0, Obstacles.Length)],SpawnPos, Quaternion.identity);
            SpawnTimer = 0;
          }
    }

}
