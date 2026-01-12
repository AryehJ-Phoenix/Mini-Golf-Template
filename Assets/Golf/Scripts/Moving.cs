using System.Threading;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float xSpeed, ySpeed, zSpeed;
    private float timer;
    public float time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = time;
        timer = timer/2;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            xSpeed = -xSpeed;
            ySpeed = -ySpeed;
            zSpeed = -zSpeed;
            timer = time;
        }


        transform.Translate(xSpeed, ySpeed, zSpeed, Space.World);
    }
}
