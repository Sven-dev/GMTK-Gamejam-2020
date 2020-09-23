using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    [SerializeField] private FlowerColor Color;
    [SerializeField] private bool Watered = false;

    public delegate void FlowerWatered(FlowerColor color);
    public static FlowerWatered OnWatered;

    private void OnTriggerEnter(Collider other)
    {
        if (!Watered)
        {
            Watered = true;
            OnWatered(Color);
        }
    }
}

public enum FlowerColor
{
    Yellow,
    Purple,
    Red
}