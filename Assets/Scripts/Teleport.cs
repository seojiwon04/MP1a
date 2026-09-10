using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference teleport;
    private double clicks = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTeleport(InputAction.CallbackContext ctx) {
        clicks++;
        Debug.Log("teleport clicked");
        if (clicks % 2 == 1) 
        {
            transform.position = new Vector3(16f, 16f, 16f);
            transform.rotation = Quaternion.Euler(30f, -133f, 0f);
        } else 
        {
            transform.position = new Vector3(0f, 5f, 0f);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }
    
    void Start()
    {
        teleport.action.Enable();
        teleport.action.performed += OnTeleport;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
