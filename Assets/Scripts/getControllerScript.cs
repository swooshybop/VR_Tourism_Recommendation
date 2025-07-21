using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;


public class getControllerScript : MonoBehaviour
{
    public ActionBasedController leftHand;
    public ActionBasedController rightHand;

    public InputActionReference leftPrimary;
    public InputActionReference rightPrimary;

    public InputActionReference leftSecondary;
    public InputActionReference rightSecondary;

    // Start is called before the first frame update
    private void Start()
    {
        leftPrimary.action.performed += LeftPrimaryPressed;
        rightPrimary.action.performed += RightPrimaryPressed;

        leftSecondary.action.performed += LeftSecondaryPressed;
        rightSecondary.action.performed += RightSecondaryPressed;
    }

    private void LeftPrimaryPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("left primary");
    }

    private void RightPrimaryPressed(InputAction.CallbackContext obj)
    {
        // Debug.Log("right primary");
        UI_Controller._instance.LocationGuidanceInteraction();
    }

    private void LeftSecondaryPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("left secondary");
    }

    private void RightSecondaryPressed(InputAction.CallbackContext obj)
    {
        //Debug.Log("right secondary");
        UI_Controller._instance.LocationGuidanceClose();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
