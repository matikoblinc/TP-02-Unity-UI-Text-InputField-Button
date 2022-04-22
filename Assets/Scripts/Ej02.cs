using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ej02 : MonoBehaviour
{
    string contraseñaCorrecta;
    string contraseñaUsuario;
    public Text ingresoUsuario;

    void Start()
    {
        contraseñaCorrecta = "123456";
    }

 
    void Update()
    {
    }
        public void validarContrasenia()
        {
        contraseñaUsuario = ingresoUsuario.text;

        if (contraseñaUsuario == contraseñaCorrecta)
        {
            Debug.Log("bienvenido");
        }
        else
        {
            Debug.Log("contraseña incorrecta");
        }

        }
    
}
