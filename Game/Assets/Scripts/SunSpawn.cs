using System.Collections;
using UnityEngine;

public class SunSpawn : MonoBehaviour
{
   public GameObject prefab;

   //initialization
    void Start() {
        // Spawn first Sun in 4 seconds, repeat every 7 seconds
        InvokeRepeating("Spawn", 4, 7);
    }

    void Spawn() {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
