using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    MeshRenderer skyObjectMeshRenederer;
    Rigidbody skyObjectRigidBody;
    void Start()
    {
        skyObjectMeshRenederer = GetComponent<MeshRenderer>();
        skyObjectMeshRenederer.enabled = false;

        skyObjectRigidBody = GetComponent<Rigidbody>();
        skyObjectRigidBody.useGravity = false;
    }

    void Update()
    {
        //Debug.Log("Time Elapsed: " + Time.time);
        if (Time.time > timeToWait)
        {
            //Debug.Log("Dropping from the sky");
           skyObjectMeshRenederer.enabled = true;
           skyObjectRigidBody.useGravity = true;

        }
    }
}
