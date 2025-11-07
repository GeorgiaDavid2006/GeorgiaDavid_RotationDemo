using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;

    public Transform upTarget;

    public float rotationSpeed = 3f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookdirection = target.position - transform.position;
        Vector3 lookup = upTarget.position;
        Quaternion rotation = Quaternion.LookRotation(lookdirection, lookup);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
    }
}
