
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public void EndJump()
    {
        PlayerController.extraGravity = -10;
    }
    public void IsJump()
    {
        PlayerController.isJumping = true;
    }
}
