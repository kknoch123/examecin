using UnityEngine;
using UnityEngine.SceneManagement;

public class Collsion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.name.Contains("PARED"))
        {
            Debug.Log("¡Tocó una pared, reiniciando escena!");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}