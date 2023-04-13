using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    //Atributos
    private float speed = 35f;
    public float speedGainPerSecond;
    public float turnSpeed;
    private int steerValue;

    // Update is called once per frame
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * -speed * Time.deltaTime);

    }
    public void Steer(int value)
    {
        steerValue = value;
    }
    public void checkLife()
    {
        Debug.Log("Suma al score");
        Destroy(gameObject);                                               //Si no tiene vida, lo destruye.
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Bullet")
        {
            Score.score++;
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            Score.score++;
            Destroy(gameObject);
        }
    }
}
