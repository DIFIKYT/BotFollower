using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VecrticalAxis = "Vertical";

    public Vector3 GetPlayerInput()
    {
        return new Vector3(Input.GetAxis(HorizontalAxis), 0, Input.GetAxis(VecrticalAxis));
    }
}