using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManagerScript;
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("Le joueur a franchi la ligne d'arrivée !");
            gameManagerScript.CompleteLevel();
        }
        
    }
}
