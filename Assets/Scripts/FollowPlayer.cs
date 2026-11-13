using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private Vector3 offset;
    
    void Update()
    {
        transform.position = transformPlayer.position + offset;
    }
}
