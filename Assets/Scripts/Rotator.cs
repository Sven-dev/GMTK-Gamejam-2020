using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float RotationSpeed;

    private Vector3 RotationTarget = Vector3.up * 180;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_RotateTowards());
    }

    /// <summary>
    /// Registers the keys
    /// </summary>
    private void Update()
    {
        //If the up key is pressed
        if (Input.GetKey(Inputs.Instance.Up))
        {
            //If the left key is also pressed
            if (Input.GetKey(Inputs.Instance.Left))
            {
                //Rotate to -45
                RotationTarget = new Vector3(0, 315, 0);
                print(RotationTarget);
            }
            //If the right key is also pressed
            else if (Input.GetKey(Inputs.Instance.Right))
            {
                //Rotate to 45
                RotationTarget = new Vector3(0, 45, 0);
            }
            //If neither key is pressed
            else
            {
                //Rotate to 0
                RotationTarget = Vector3.zero;
            }
        }
        else if (Input.GetKey(Inputs.Instance.Down))
        {
            //If the left key is also pressed
            if (Input.GetKey(Inputs.Instance.Left))
            {
                //Rotate to -135
                RotationTarget = new Vector3(0, 225, 0);
            }
            //If the right key is also pressed
            else if (Input.GetKey(Inputs.Instance.Right))
            {
                //Rotate to 135
                RotationTarget = new Vector3(0, 135, 0);
            }
            //If neither key is pressed
            else
            {
                //Rotate to 180
                RotationTarget = new Vector3(0, 180, 0);
            }
        }
        else if (Input.GetKey(Inputs.Instance.Left))
        {
            //Rotate to -90
            RotationTarget = new Vector3(0, 270, 0);
            print(RotationTarget);
        }
        else if (Input.GetKey(Inputs.Instance.Right))
        {
            //Rotate to 90
            RotationTarget = new Vector3(0, 90, 0);
        }
    }

    /// <summary>
    /// Rotate the object towards RotationTarget
    /// </summary>
    private IEnumerator _RotateTowards()
    {
        while (true)
        {
            while (transform.eulerAngles != RotationTarget)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(RotationTarget), RotationSpeed);
                yield return null;
            }

            yield return null;
        }
    }
}
