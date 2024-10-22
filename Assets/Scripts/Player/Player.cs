using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void FixedUpdate()
    {
        _playerMovement.Move(_playerInput.GetPlayerInput());
    }
}