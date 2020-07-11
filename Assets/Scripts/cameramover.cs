using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime);
    }
}