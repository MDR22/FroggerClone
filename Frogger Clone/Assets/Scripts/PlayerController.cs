using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputActions inputActions;
    private InputAction movement;
    private Rigidbody2D playerRb;
    private float playerSpeed = 5.0f;
    //private float upperBound = 3.95f;
    //private float lowerBound = -3.95f;

    private void Awake()
    {
        inputActions = new InputActions();
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        movement = inputActions.Frogger.Movement;
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    private void FixedUpdate()
    {

        //Add movement functionality
        //Calculating the player movement velocity
        Vector2 input = movement.ReadValue<Vector2>();
        Vector2 newPosition = playerRb.position + input * playerSpeed * Time.fixedDeltaTime;
        playerRb.MovePosition(newPosition);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Boundaries();
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
