using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Aqui haremos que la camara siga al jugador con las distancias indicadas
    public GameObject player;
    private Vector3 offset = new Vector3(15, 2, 5);

    // para que funcione el codigo de arriba
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
