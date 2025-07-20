using UnityEngine;

[RequireComponent(typeof(VRMManager))]
[RequireComponent(typeof(PlayerController))]
public class VRMMarioController : MonoBehaviour
{
    private PlayerController player;
    private Animator animator;
    private VRMManager vrmManager;

    void Awake()
    {
        player = GetComponent<PlayerController>();
        vrmManager = GetComponent<VRMManager>();
    }

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (animator != null)
        {
            animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical")));
            animator.SetBool("IsGrounded", player != null && player.IsGrounded);
        }
    }
}
