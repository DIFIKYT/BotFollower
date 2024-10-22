using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    public void Move(Vector3 playerInput)
    {
        playerInput *= Time.deltaTime * _moveSpeed;

        if (_characterController != null)
        {
            if (_characterController.isGrounded)
            {
                _characterController.Move(playerInput + Physics.gravity);
            }
            else
            {
                _characterController.Move(_characterController.velocity + Physics.gravity * Time.deltaTime);
            }
        }
    }
}