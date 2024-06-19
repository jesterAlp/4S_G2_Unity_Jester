using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PinkGateTrigger pinkTrigger;
    private GreenGateTrigger greenTrigger;
    
    private ControllActions inputActions;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator anim;

    [SerializeField] private float speed;
    private bool greenIsInteracting;
    private bool pinkIsInteracting;

    public GameObject pauseScreen;

    private void Awake()
    {
        inputActions = new ControllActions();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = moveInput * speed;
    }

    public void Movement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void PauseGame(InputAction.CallbackContext context)
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}
