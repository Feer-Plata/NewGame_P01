using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanw : MonoBehaviour
{
    //Atributos
    public bool PuedeSpawnear = true;
    public GameObject RedAstreroid;
    public List<Transform> posicionAster;

    private void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (PuedeSpawnear)
        {
            StartCoroutine(SpawnAsteroids(3.5f));
        }
    }
    IEnumerator SpawnAsteroids(float time)
    {
        int posiciones = Random.Range(0, 2);
        if (posiciones == 0)
        {
            Instantiate(RedAstreroid, posicionAster[0].position, Quaternion.identity);
        }
        else
        {
            Instantiate(RedAstreroid, posicionAster[1].position, Quaternion.identity);
        }
        PuedeSpawnear = false;
        yield return new WaitForSeconds(time);
        PuedeSpawnear = true;
    }
}
