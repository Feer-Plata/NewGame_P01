using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    //Atributos
    public float speed;
    public float speedGainPerSecond;
    public float turnSpeed;
    private int steerValue;

    // Update is called once per frame
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    public void Steer(int value)
    {
        steerValue = value;
    }
}
