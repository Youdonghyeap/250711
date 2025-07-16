using UnityEngine;

public class PlayerDance : MonoBehaviour
{
    private Animator animator;
    private bool isDancing = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 좌클릭
        {
            isDancing = !isDancing;
            animator.SetBool("IsDancing", isDancing);
        }
    }
}