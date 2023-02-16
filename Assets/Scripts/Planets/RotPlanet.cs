using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPlanet : MonoBehaviour
{
    //Atributos
    public float vRotacion = 10;
    public Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
