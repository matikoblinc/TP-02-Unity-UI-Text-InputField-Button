using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ej02 : MonoBehaviour
{
    string contraseñaCorrecta;
    string contraseñaUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject CartelitoMensaje;

    void Start()
    {
        contraseñaCorrecta = "123456";
        CartelitoMensaje.SetActive(false);
    }

 
    void Update()
    {
    }
        public void validarContrasenia()
        {
        contraseñaUsuario = ingresoUsuario.text;

        if (contraseñaUsuario == contraseñaCorrecta)
        {
            CartelitoMensaje.SetActive(true);
            textoMsj.text = "bienvenido";
            Debug.Log("bienvenido");
            
        }
        else
        {
            CartelitoMensaje.SetActive(true);
            textoMsj.text = "contraseña incorrecta";
            Debug.Log("contraseña incorrecta");
        }

        }
    
}
