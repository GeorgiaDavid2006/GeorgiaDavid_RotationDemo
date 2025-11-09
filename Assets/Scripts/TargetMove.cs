using UnityEditor.Rendering;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    private float speed = 5;

    public float startPosX = 0;
    public float startPosY = 0;

    public bool moveX = true;
    public bool moveY = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(moveX == true)
        {
            transform.position = new Vector3(Mathf.Sin(Time.time * speed) * speed + startPosX, transform.position.y, transform.position.z);
        }
        else if(moveY == true)
        {
            transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
        }
        
        
    }
}
