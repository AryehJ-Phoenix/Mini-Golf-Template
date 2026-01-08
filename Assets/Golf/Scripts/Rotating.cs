using UnityEngine;

public class Rotating : MonoBehaviour

{
    public float xAngle, yAngle, zAngle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle,Space.World);
    }
}
