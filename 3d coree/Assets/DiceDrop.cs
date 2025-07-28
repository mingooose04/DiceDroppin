using UnityEngine;
using UnityEngine.InputSystem;

public class DiceDrop : MonoBehaviour
{
    private Rigidbody dice;
    private bool isDropped = false;

    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;


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
        if (isDropped && dice.isSleeping()){

            
        }
    }
}
