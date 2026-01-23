using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Moving : MonoBehaviour
{
    public float xSpeed, ySpeed, zSpeed;
    public bool position_based;
    public List<Vector3> positions;
    private Vector3 next;
    private int target = 0;
    public float speed = 0.0025f;
    private float timer;
    public float time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = time/2;
    }

    // Update is called once per frame
    void Update()
    {
        if (!position_based)
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

        if (position_based && positions.Count > 0)
        {
            float distance = Vector3.Distance(transform.position, positions[target]);
            if(distance <= 0.1)
            {
                target += 1;
                target = target % positions.Count();
            }
            
            next = positions[target];
            // GET THIS WORKING PLEEEAAASSSEEEEEEEEEEEEEEEE
            transform.position = Vector3.MoveTowards(transform.position, next, speed);
        }
    }
}
