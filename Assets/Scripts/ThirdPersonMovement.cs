using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class ThirdPersonMovement : MonoBehaviour
{

    [SerializeField]
    private InputActionReference movementControl;
    [SerializeField]
    private InputActionReference jumpControl;
    [SerializeField]
    private InputActionReference colorControl;
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 0.1f;
    [SerializeField]
    private float gravityValue = -9.81f;
    [SerializeField]
    private float rotationSpeed = 4.00f;

    private CharacterController controller;

    [SerializeField]
    private Vector3 playerVelocity;

    [SerializeField]
    private bool groundedPlayer;


    private Transform cameraMain;
    private int currentIndex;
    private Animator animator;



    [SerializeField]
    public Material[] colours;


    private void OnEnable()
    {
        movementControl.action.Enable();
        jumpControl.action.Enable();
        colorControl.action.Enable();



    }

    private void OnDisable()
    {
        movementControl.action.Disable();
        jumpControl.action.Disable();
        colorControl.action.Disable();

    }

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        cameraMain = Camera.main.transform;
        animator = GetComponentInChildren<Animator>();
        currentIndex = 0;
    }

    void Update()
    {

        playerVelocity.y += gravityValue * Time.deltaTime;

        if (groundedPlayer)
        {
            playerVelocity.y = -1.0f;
        }

        Vector2 movement = movementControl.action.ReadValue<Vector2>();

        Vector3 move = new Vector3(movement.x, 0, movement.y);

        move = cameraMain.forward * move.z + cameraMain.right * move.x;
        move.y = 0.0f;

        controller.Move(move * Time.deltaTime * playerSpeed);




        // Changes the height position of the player..
        if (jumpControl.action.triggered && groundedPlayer)
        {
           
              playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
                

            
        }

        if (colorControl.action.triggered)
        {
            

            gameObject.GetComponentInChildren<Renderer>().material = colours[0];
            Debug.Log("Color Changed");
        }

 
        controller.Move(playerVelocity * Time.deltaTime);

        if(movement != Vector2.zero)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.y) * Mathf.Rad2Deg + cameraMain.transform.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0.0f, targetAngle, 0.0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
            animator.SetInteger("animState", 1);
        }
        else
        {
            
             animator.SetInteger("animState", 0);
            
        }

        if (!groundedPlayer)
        {
            animator.SetInteger("animState", 2);
        }
 

        groundedPlayer = controller.isGrounded;


    }
}