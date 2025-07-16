using System.Collections.Generic;
using UnityEngine;
using Unity.Cinemachine;

// controla o registro de câmeras e a transição entre múltiplas câmeras do Cinemachine
public class PBCameraManager : MonoBehaviour
{
    // Lista estática que armazena todas as câmeras registradas
    static List<CinemachineCamera> cameras = new List<CinemachineCamera>();

    // Referência para a câmera ativa no momento
    public static CinemachineCamera ActiveCamera = null;

    // Verifica se uma câmera específica é a câmera ativa atual
    public static bool IsActiveCamera(CinemachineCamera camera)
    {
        return camera == ActiveCamera;
    }

    // Método para trocar para uma nova câmera
    public static void SwitchCamera(CinemachineCamera newCamera)
    {
        // Define alta prioridade para a nova câmera (Cinemachine usa prioridade para determinar a câmera ativa)
        newCamera.Priority = 10;
        
        // Atualiza a referência da câmera ativa
        ActiveCamera = newCamera;

        // Percorre todas as câmeras registradas
        foreach (CinemachineCamera cam in cameras)
        {
            // Para todas as câmeras que NÃO são a nova câmera
            if (cam != newCamera)
            {
                // Define prioridade baixa para desativá-las
                cam.Priority = 0;
            }
        }
    }

    // Registra uma nova câmera no gerenciador
    public static void Register(CinemachineCamera camera)
    {
        cameras.Add(camera);
    }

    // Remove uma câmera do gerenciador (quando não está mais em uso)
    public static void Unregister(CinemachineCamera camera)
    {
        cameras.Remove(camera);
    }
}