using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActionAseet;

    private InputAction inputAction;
    private InputAction moveAction;
    public Rigidbody2D Rigidbody2D;
    public CharacterController CharacterController;


    [SerializeField] private Vector2 move;


    [SerializeField] private float speed;

    private void OnEnable()
    {
        inputActionAseet.FindActionMap("Pleyer").Enable();
    }

    private void OnDisable()
    {
        inputActionAseet.FindActionMap("Pleyer").Enable();
    }


    private void Awake()
    {
        CharacterController = GetComponent<CharacterController>();

        Rigidbody2D = GetComponent<Rigidbody2D>();

        inputAction = inputActionAseet.FindAction("interact");
        moveAction = inputActionAseet.FindAction("Move");
    }


    private void Update()
    {
        move = moveAction.ReadValue<Vector2>();
        Movement();

    }


    public void Movement()
    {
        Vector3 direction = new Vector3(move.x, 0, 0);
        transform.position += direction * speed * Time.deltaTime;
        // Rigidbody2D.AddForce(move.normalized * speed, ForceMode2D.Force);
        //CharacterController.SimpleMove(direction.normalized * speed);

    }
}






