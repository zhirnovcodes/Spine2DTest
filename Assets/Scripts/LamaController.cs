using UnityEngine;
using UnityEngine.UI;

public class LamaController : MonoBehaviour
{
    public Animator Animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void Jump()
    {
        Animator.SetTrigger("Jump");
    }
}
