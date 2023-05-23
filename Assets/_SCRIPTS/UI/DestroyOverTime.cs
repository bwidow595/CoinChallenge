using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    private float lifetime = 1.2f;
    void Update()
    {
        Destroy(gameObject, lifetime);
    }
}
