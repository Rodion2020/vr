using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    public string SpawnPoolTag = "EnemyPool";
    public float SpawnInterval = 5f;
    private ObjectPool Pool = null;
    void Awake()
    {
        Pool = GameObject.FindWithTag(SpawnPoolTag).GetComponent<ObjectPool>();

    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", SpawnInterval, SpawnInterval);
    }

    public void Spawn()
    {
        Pool.Spawn(null, transform.position, transform.rotation, Vector3.one);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
