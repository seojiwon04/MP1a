using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectShoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject star;
    public ParticleSystem poof;
    public InputActionReference spawnButton;
    public Transform controller;
    public AudioClip poofSound;
    void OnSpawn(InputAction.CallbackContext ctx)
    {
        GameObject starObj = Instantiate(star, controller.position, controller.rotation * Quaternion.Euler(-45f,0f,0f));
        starObj.GetComponent<StarVelocity>().velocity = controller.forward * 10f;
        Instantiate(poof, controller.position, controller.rotation);
        AudioSource.PlayClipAtPoint(poofSound, controller.position);
        Debug.Log("left button pressed");
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
