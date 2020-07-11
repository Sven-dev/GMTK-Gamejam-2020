using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    [Header("Movement keys")]
    public KeyCode Up;
    public KeyCode Left;
    public KeyCode Down;
    public KeyCode Right;

    public static Inputs Instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}