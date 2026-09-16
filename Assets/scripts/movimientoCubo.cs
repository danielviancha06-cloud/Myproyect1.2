using UnityEngine;

public class movimientoCubo : MonoBehaviour
{

    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movementInput;

    void Start()
    {
        // Obtenemos la referencia al componente Rigidbody2D del personaje
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Capturamos la entrada del teclado (Horizontal y Vertical)
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        //Normalizamos el vector para evitar que el personaje se mueva más rápido en diagonal
        movementInput = movementInput.normalized;
    }

    void FixedUpdate()
    {
        // Movemos al personaje utilizando la física del Rigidbody2D
        rb.linearVelocity = movementInput * moveSpeed;
    }
}

