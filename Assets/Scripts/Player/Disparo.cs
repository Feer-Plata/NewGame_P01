using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    //Atributos Disparo
    public GameObject bullet;
    public List<Transform> posBullet;
    [SerializeField] private Transform shootCtrl;
    [SerializeField] private GameObject shoot;
    [SerializeField] private float tiempoEntredisparos;
    private float tiempoSigDisp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >=tiempoSigDisp)
        {
            Disparar();
            tiempoSigDisp = Time.time + tiempoEntredisparos;
        }
    }
    private void Disparar()
    {
        Instantiate(bullet, posBullet[0].position, Quaternion.identity);
        Instantiate(bullet, posBullet[1].position, Quaternion.identity);
    }
}
