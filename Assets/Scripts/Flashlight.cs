using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private InputActionReference toggleAction;
    [SerializeField] private Light flashLight;
    [SerializeField] private AudioSource flashLightSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnEnable()
    {
        toggleAction.action.performed += OnToggle;
    }

    private void OnDisable()
    {
        toggleAction.action.performed += OnToggle;
    }

    private void OnToggle(InputAction.CallbackContext ctx)
    {
        flashLight.enabled = !flashLight.enabled;
        flashLightSound.Play();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
