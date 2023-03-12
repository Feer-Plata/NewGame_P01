using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Atributos
    private Rigidbody rbEnemy;
    private GameObject player;
    public float speedDesplace;
    // Start is called before the first frame update
    void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > -8)
        {
            this.transform.position = new Vector3(-25, 0, 0);
        }
        transform.Translate(0, 0, speedDesplace * Time.deltaTime);
        rbEnemy.AddForce(player.transform.position - transform.position);
    }

}
