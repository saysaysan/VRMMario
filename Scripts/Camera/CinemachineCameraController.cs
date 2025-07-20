using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineCameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float followSpeed = 10f;

    private CinemachineVirtualCamera virtualCamera;
    private CinemachineTransposer transposer;

    void Awake()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        transposer = virtualCamera.GetCinemachineComponent<CinemachineTransposer>();
    }

    void Start()
    {
        if (target != null)
        {
            virtualCamera.Follow = target;
        }
        if (transposer != null)
        {
            transposer.m_FollowOffset = offset;
        }
    }

    void LateUpdate()
    {
        if (virtualCamera.Follow == null && target != null)
        {
            virtualCamera.Follow = target;
        }

        if (transposer != null)
        {
            Vector3 desiredOffset = offset;
            transposer.m_FollowOffset = Vector3.Lerp(transposer.m_FollowOffset, desiredOffset, followSpeed * Time.deltaTime);
        }
    }
}
