using UnityEngine;

public class PlayerContinuousMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad = 5f;
    private Vector2 direccionActual = Vector2.right; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        if (inputX != 0)
        {
            direccionActual = new Vector2(inputX, 0).normalized;
        }
        else if (inputY != 0)
        {
            direccionActual = new Vector2(0, inputY).normalized;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direccionActual * velocidad;
    }
}