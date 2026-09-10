using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject star;
    public ParticleSystem poof;
    public InputActionReference spawnButton;
    public Transform controller;
    void OnSpawn(InputAction.CallbackContext ctx)
    {
        Instantiate(star, controller.position, controller.rotation);
    }

    void Start()
    {
        spawnButton.action.Enable();
        spawnButton.action.performed += OnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
