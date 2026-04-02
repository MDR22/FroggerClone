using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputActions inputActions;
    private InputAction movement;
    private Rigidbody2D playerRb;
    public float playerSpeed = 3.0f;
    //private float upperBound = 3.95f;
    //private float lowerBound = -3.95f;

    private void Awake()
    {
        inputActions = new InputActions();
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        //movement = inputActions.Frogger.Movement;
        //movement.Enable();

        //InputActions.inputActions.Movement.performed += GridMovement;
        inputActions.Frogger.Movement.performed += GridMovement;    
        inputActions.Frogger.Movement.Enable();    
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    //private void FixedUpdate()
    //{
    //    // To control movement, I only want Frogger to move once per key press. If key is held down, Frogger should not move. If key is released, Frogger should move once in the direction of the key press. To achieve this, I will use the InputAction's performed event to trigger movement instead of reading the value in FixedUpdate.
    //    //Add movement functionality
    //    //Calculating the player movement velocity
    //    Vector2 input = movement.ReadValue<Vector2>();
    //    //Vector2 newPosition = playerRb.position + input * playerSpeed * Time.fixedDeltaTime;
    //    Vector2 newPosition = playerRb.position + input;
    //    Debug.Log("playerRb.position is " + playerRb.position + "; " + "input is " + input + "; " + "playerSpeed is " + playerSpeed + "; " + "Time.fixedDeltaTime is " + Time.fixedDeltaTime);
    //    //playerRb.MovePosition(newPosition);
    //    transform.position = newPosition;
    //    //playerRb.transform.position = ;

    //    // playerRb.position is (-3.98, 1.38); input is (-1.00, 0.00); playerSpeed is 5; Time.fixedDeltaTime is 0.01999999
    //}

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Boundaries();
    }

    private void GridMovement(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Vector2 input = context.ReadValue<Vector2>();
            Vector2 newPosition = playerRb.position + input;
            //Vector2 newPosition = playerRb.position + input * playerSpeed;
            transform.position = newPosition;
            Debug.Log("playerRb.position is " + playerRb.position + "; " + "input is " + input + "; " + "playerSpeed is " + playerSpeed + "; ");
        }
    }
    private void Boundaries()
    {
        // Set boundaries for the player to prevent moving off screen
        
        //if (transform.position.y > upperBound)
        //{
        //    //Debug.Log("Hit upper bound");
        //    transform.position = new Vector3(transform.position.x, upperBound, transform.position.z);

        //}

        //else if (transform.position.y < lowerBound)
        //{
        //    //Debug.Log("Hit lower bound");
        //    transform.position = new Vector3(transform.position.x, lowerBound, transform.position.z);

        //}
    }
}
