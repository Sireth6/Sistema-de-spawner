using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float countdown;
    public GameObject[] spawners;
    public GameObject enemy;


    private void Start()
    {
        spawners = new GameObject[5];

        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
        }

    }



    private void SpawnEnemy()
    {
        int spawnerID = Random.Range(0, spawners.Length);
        while (true)
        {
            Instantiate(enemy, spawners[spawnerID].transform.position, spawners[spawnerID].transform.rotation);
            yield return new WaitForSeconds(5f);
        }
    }
}