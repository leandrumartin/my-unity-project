using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    public float previousAmount;
    public float amount;
    public UnityEvent onDeath;
    public UnityEvent onLifeUpdate;

    void Update()
    {
        if (amount <= 0)
        {
            onDeath.Invoke();
            Destroy(gameObject);
        }
        if (amount != previousAmount)
        {
            onLifeUpdate.Invoke();
            previousAmount = amount;
        }
    }

    public void SetAmount(float newAmount)
    {
        amount = newAmount;
        onLifeUpdate.Invoke();
    }

    public void ChangeAmount(float delta)
    {
        SetAmount(amount + delta);
    }
}
