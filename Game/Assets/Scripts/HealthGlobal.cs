using System.Collections;
using UnityEngine;

public class HealthGlobal : MonoBehaviour
{
    // Current Health of Object
    [SerializeField]
    int cur = 5;

    public void doDamage(int n) {
        // Subtract damage from current health
        cur -= n;

         // Destroy if died
        if (cur <= 0) {
            Destroy(gameObject);
        }
    }
}
