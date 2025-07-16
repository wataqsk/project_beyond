using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.InputSystem;

public class PBPlayerCamera : MonoBehaviour
{
    public CinemachineCamera ThirdPerson;
    public CinemachineCamera Isometric;
    
    [Header("Input Keys")]
    public Key SwitchToThirdPersonKey = Key.Digit1;
    public Key SwitchToIsometricKey = Key.Digit2;

    private void Update()
    {
        var keyboard = Keyboard.current;
        
        if (keyboard[SwitchToThirdPersonKey].wasPressedThisFrame)
        {
            PBCameraManager.SwitchCamera(ThirdPerson);
        }

        if (keyboard[SwitchToIsometricKey].wasPressedThisFrame)
        {
            PBCameraManager.SwitchCamera(Isometric);
        }
    }
}