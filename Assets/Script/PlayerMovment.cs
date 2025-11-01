using UnityEngine;


public class PlayerMovment : MonoBehaviour
{
    public float movmentSpeed = 7f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void  FixedUpdate()//This makes it run by game time
    {
        Vector3 moveDir = transform.right*Input.GetAxis("Horizontal") * movmentSpeed + transform.forward*Input.GetAxis("Vertical")*movmentSpeed;
        
        //This vector repesents where we want to go, our new direction
        
    }
}
