using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // The Bullet Prefab
    public GameObject zombiePrefab;

    public float interval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartSpawn", 0, interval);
    }

    void StartSpawn() {
        Instantiate(zombiePrefab, transform.position, Quaternion.identity);
    }
}
