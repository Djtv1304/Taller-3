using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public int puntos = 0; // Contador de puntos

    // Este método se llama cuando el target colisiona con otro objeto
    private void OnCollisionEnter(Collision collision)
    {
        // Comprueba si la colisión ocurrió con un objeto que tiene el Layer "Bala"
        if (collision.gameObject.layer == LayerMask.NameToLayer("Balas"))
        {
            // Si colisionó con una bala, suma 5 puntos
            puntos += 5;

            // Comprueba si se alcanzaron los 20 puntos
            if (puntos >= 20)
            {
                // Si se alcanzaron los 20 puntos, termina el juego y muestra el puntaje final
                TerminarJuego();
            }
        }
    }

    // Método para terminar el juego y mostrar el puntaje final
    private void TerminarJuego()
    {

        Debug.Log("¡Felicitaciones! ¡Has ganado! " + "Tu Puntaje final: " + puntos);

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}
