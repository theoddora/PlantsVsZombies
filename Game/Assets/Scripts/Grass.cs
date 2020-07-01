using System.Collections;
using UnityEngine;

public class Grass : MonoBehaviour
{
    void OnMouseUpAsButton() {
        if (BuildMenu.current != null) {
            Instantiate(BuildMenu.current.gameObject, transform.position, Quaternion.identity);
            MouseCollect.score -= BuildMenu.current.price;
            BuildMenu.current = null;
        }
    }
}
