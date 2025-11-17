using UnityEngine;
using UnityEngine.UI;

public class LamaController : MonoBehaviour
{
    public Animator Animator;

    public void Jump()
    {
        Animator.SetTrigger("Jump");
    }
}
