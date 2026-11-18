using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float forwardForce = 10.0f;
    [SerializeField] private float sidewaysForce = 10.0f;
    [SerializeField] private Rigidbody rbPlayer;
    
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, forwardForce);

        if (Input.GetKey(KeyCode.D))
        {
            rbPlayer.AddForce(sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            rbPlayer.AddForce(-sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        
    }
}
