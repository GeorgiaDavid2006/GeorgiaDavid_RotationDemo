using UnityEngine;

public class OrbitCube : MonoBehaviour
{
    public Transform cube;

    public float movementSpeed = 5;

    public float rotationSpeed = 100;

    void Start()
    {
        Vector3 startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, cube.transform.rotation, rotationSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }
}
