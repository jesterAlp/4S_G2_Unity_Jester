using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class PlayerSwitch : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    public GameObject green;
    public GameObject pink;
    private ControllActions inputActions;
    private bool switchToGreen;
    private bool switchToPink;

    private void Awake()
    {
        inputActions = new ControllActions();
        pink.SetActive(false);
    }

    public void SwitchToPink(InputAction.CallbackContext context)
    {
        switchToPink = context.performed;
        green.SetActive(false);
        pink.SetActive(true);

        cam.Follow = pink.transform;
        pink.transform.position = green.transform.position;
    }

    public void SwitchToGreen(InputAction.CallbackContext context)
    {
        switchToGreen = context.performed;
        pink.SetActive(false);
        green.SetActive(true);
        
        cam.Follow = green.transform;
        green.transform.position = pink.transform.position;
    }
}
