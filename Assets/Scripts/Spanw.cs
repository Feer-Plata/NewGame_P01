using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanw : MonoBehaviour
{
    //Atributos
    public bool PuedeSpawnear = true;
    public GameObject[] Astreroids;
    public Transform[] posAster;


    private void Update()
    {
        InstantiateObj();
    }

    private void InstantiateObj()
    {
        if (PuedeSpawnear)
        {
            StartCoroutine(SpawnAsteroids(1f));
        }
    }
    IEnumerator SpawnAsteroids(float time)
    {
        int n = Random.Range(0, Astreroids.Length);
        int w = Random.Range(0, posAster.Length);
        if (n == 0)
        {
            Instantiate(Astreroids[n], posAster[w].position, Astreroids[n].transform.rotation);
        }
        else
        {
            Instantiate(Astreroids[n], posAster[w].position, Astreroids[n].transform.rotation);
        }

                

        PuedeSpawnear = false;
        yield return new WaitForSeconds(time);
        PuedeSpawnear = true;
    }
}
