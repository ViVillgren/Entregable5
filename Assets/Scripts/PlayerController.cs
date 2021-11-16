using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Con el estos codigos haremos que en este caso el Player, aparezca en el 0, 0, 0 de la escena y tendra una velocidad constante tanto para ir hacia delante como para girar arriba y abajo, ademas de poner un limite en la escena
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10.0f;
    private float verticalInput;
    private float turnSpeed = 20.0f;
    private float zMax = 450;

    //Aqui cada vez que iniciemos el Player ira al punto inicial que hemos indicado arriba
    void Start()
    {
        transform.position = initialPos;
    }

    //El control esta hehco para que funcione tanto con las fechas arriba y abajo como con W y S para subir y bajar el Player a la velocidad indicada en el inicio.
    //Tambien que cuando la posicion haya llegado al maximo que indicamos arriba el juego se acabe y pare el tiempo del juego.
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.right, turnSpeed * verticalInput * Time.deltaTime);

        if (transform.position.z > zMax)
        {
            Debug.Log($"THE END");
            Time.timeScale = 0;
        }
    }
}
