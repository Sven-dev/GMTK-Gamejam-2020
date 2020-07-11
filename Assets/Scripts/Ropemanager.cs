using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ropemanager : MonoBehaviour
{
    [SerializeField] private RopeJoint JointPrefab;
    [Space]
    [SerializeField] private int RopeLength;
    [SerializeField] private List<RopeJoint> RopeParts;
    [Space]
    [SerializeField] private Rigidbody Player;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= RopeLength; i++)
        {
            SpawnBall();
        }

        RopeJoint lastjoint = RopeParts[RopeParts.Count - 1];
        lastjoint.Hingejoint.connectedBody = Player;
        lastjoint.transform.parent = Player.transform;
        lastjoint.transform.position = Player.transform.position;

        RopeParts[0].Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }

    /// <summary>
    /// Spawns a ball, and attaches it to the previous ball
    /// </summary>
    private void SpawnBall()
    {
        Vector2 spawnposition = RopeParts[RopeParts.Count - 1].transform.position;
        //spawnposition.x++;

        RopeJoint jointclone = Instantiate(JointPrefab, spawnposition, Quaternion.identity, transform);
        RopeParts.Add(jointclone);

        RopeParts[RopeParts.Count - 2].Hingejoint.connectedBody = jointclone.Rigidbody;
    }
}