using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovermentScript;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("On a touché " + collisionInfo.collider.name);
            playerMovermentScript.enabled = false;
        }
        
    }
}
