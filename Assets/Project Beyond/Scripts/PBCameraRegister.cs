using Unity.Cinemachine;
using UnityEngine;
 
public class PBCameraRegister : MonoBehaviour
{
    private void OnEnable()
    {
        PBCameraManager.Register(GetComponent<CinemachineCamera>());
    }
    private void OnDisable()
    {
        PBCameraManager.Unregister(GetComponent<CinemachineCamera>());
    }
}