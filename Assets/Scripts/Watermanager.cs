using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermanager : MonoBehaviour
{
    [SerializeField] private LayerMask Mask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, Vector3.forward * 20, Color.red, Time.deltaTime);
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 20))
        {
            if (hit.collider.tag == "Flower")
            {
                print("flower found!");
            }
        }
    }
}