using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    [SerializeField] private float damage;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Life life = other.GetComponent<Life>();
        if (life != null)
        {
            life.ChangeAmount(0 - damage);
        }
    }
}
