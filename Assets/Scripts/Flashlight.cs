using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private InputActionReference toggleAction;
    [SerializeField] private Light flashLight;
    [SerializeField] private AudioClip flashLightSound;
     private new AudioSource audio; //Will hold the AudioSource Component

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
        audio.PlayOneShot(flashLightSound);
        flashLight.enabled = !flashLight.enabled;
        //flashLightSound.Play();
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
