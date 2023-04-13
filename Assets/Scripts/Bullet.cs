using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Atributos
    public int speedBullet;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0,0, speedBullet * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Astro")
        {
            Destroy(gameObject);
        }
    }
}
