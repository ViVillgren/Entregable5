using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Aqui hacemos que el que tenga el script sea posible asignarle un Game Object, en este caso el obstaculo, la distancia que aparece, una variable random y un limite. Asi que el Game Object indicado aparezca en la escena
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    public float randomY;
    private float limY = 10f;

    // Aqui el codigo hara que aparezca el objeto indicado en el Game Object inicie tras 0.5 segundo y se repita cada tiempo determinado
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, 5f);
    }

    //Aqui usaremos la variable random para hacer que el obstaculo aparezca entre los limites indicados cada 50 metros mas adelante
    public void SpawnObstacle()
    {
        randomY = Random.Range(-limY, limY);
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
