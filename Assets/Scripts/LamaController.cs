using UnityEngine;
using UnityEngine.UI;

public class LamaController : MonoBehaviour
{
    public Animator Animator1;
    public Animator Animator2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void Jump()
    {
        Animator1.SetTrigger("Jump");
        Animator2.SetTrigger("Jump");
    }
}
