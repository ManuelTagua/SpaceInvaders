using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class JugadorMovimiento : MonoBehaviour
{
    [Header("Movimiento")]
    public float moveSpeed = 5f;

    private CharacterController controller;
    private Transform cameraPivot;

    private Vector3 velocity;
    private float xRotation = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // ----- MOVIMIENTO -----
        float x = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * x;
        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}
