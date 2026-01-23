using Unity.VisualScripting;
using UnityEngine;

public class Ball_Teleporter : MonoBehaviour
{
    public Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.transform.position = target;
            other.gameObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(0,0,0);
        }
    }
}
