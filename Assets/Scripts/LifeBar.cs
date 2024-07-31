using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    private Image image;
    public Life targetLife;

    void Awake()
    {
        image = GetComponent<Image>();
        targetLife.onLifeUpdate.AddListener(SetSize);
    }

    void Update()
    {
    }

    void SetSize()
    {
        image.fillAmount = targetLife.amount / 100;
    }
}
