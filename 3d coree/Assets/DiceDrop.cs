using UnityEngine;
using UnityEngine.InputSystem;

public class DiceDrop : MonoBehaviour
{
    private Rigidbody dice;
    private bool isDropped = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dice = GetComponent<Rigidbody>();
        dice.useGravity = false;
    }

    public void droppedDice(InputAction.CallbackContext context)
    {
        if(context.performed && !isDropped)
        {
            dice.useGravity = true;
            isDropped = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
