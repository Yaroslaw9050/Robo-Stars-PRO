using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class PlayerController : MonoBehaviourPunCallbacks
{
    [SerializeField] private CameraFolow myCamScript;
    [SerializeField] private float rotateSpeed; 
    private PlayerInput inputActions;
    private CharacterController controller; 
    private Animator animator;
    private Vector2 movementInput;
    private Vector3 currentMovement; 
    private  Quaternion rotateDir;
    private bool isRun;
    private bool isWalk;
    private PhotonView pv;

    private void Awake()
    {
        pv = GetComponentInParent<PhotonView>();
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>(); 
        inputActions = new PlayerInput();

        inputActions.CharacterControllers.Movement.started += OnMovemntActions;
        inputActions.CharacterControllers.Movement.performed += OnMovemntActions;
        inputActions.CharacterControllers.Movement.canceled += OnMovemntActions; 


        inputActions.CharacterControllers.Movement.started += OnCameraMovement;
        inputActions.CharacterControllers.Movement.performed += OnCameraMovement;
        inputActions.CharacterControllers.Movement.canceled += OnCameraMovement; 

        inputActions.CharacterControllers.Run.started += OnRun;
        inputActions.CharacterControllers.Run.canceled += OnRun;

        if(!pv.IsMine)
        {
            Destroy(myCamScript.gameObject);
        }
        
    }
    private void OnEnable()
    {
        inputActions.CharacterControllers.Enable();
    }
    private void OnDisable()
    {
        inputActions.CharacterControllers.Disable();
    }
    private void Update()
    {
        if(!pv.IsMine) return;

        AnimateControl();
        PlayerRotate();
    }
    private void FixedUpdate()
    {
        if(!pv.IsMine) return;

        controller.Move(currentMovement * Time.fixedDeltaTime); 
    }
    private void OnCameraMovement(InputAction.CallbackContext context)
    {
        myCamScript.SetOffset(currentMovement);
    }
    private void OnMovemntActions(InputAction.CallbackContext context)
    {
            // при спрацюванні метода - запишемо дані про натиснуті клавіші в movementInput
            movementInput = context.ReadValue<Vector2>();
            // оскільки натискання кнопок зчитуться у Vector 2, а у нас 3D гра - перетворимо вісь Y (стрілки вгору та вниз) на вісь Z (рух вперед/назад)
            currentMovement.x = movementInput.x;
            currentMovement.z = movementInput.y;
            // якщо натиснута хоча-б одна клавіша - запишемо в isWalk true.
            isWalk = movementInput.x != 0 || movementInput.y != 0;       

    }
    private void OnRun(InputAction.CallbackContext context)
    {
        isRun = context.ReadValueAsButton();
    }
    private void PlayerRotate()
    {
        if(isWalk)
        {
            rotateDir = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(currentMovement),Time.deltaTime * rotateSpeed);
            transform.rotation = rotateDir;
        }
    }
    private void AnimateControl()
    {
        animator.SetBool("isWalk", isWalk);
        animator.SetBool("isRun", isRun);
    }
    public void Respawn()
    {
        controller.enabled = false;
        transform.position = Vector3.up;
        controller.enabled = true;
    }
}
