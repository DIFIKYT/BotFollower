using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bot : MonoBehaviour
{
    [SerializeField] private BotMovement _botMovement;

    private void FixedUpdate()
    {
        _botMovement.MoveTo();
    }
}