using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    const string JUMP_INPUT_BUTTON_NAME = "Jump";
    const string HORIZONTAL_INPUT_NAME = "Horizontal";
    const string VERTICAL_INPUT_NAME = "Vertical";

    private Rigidbody _rigidBody;

    [SerializeField] float _groundCheckRadius = 0.5f;

    [SerializeField] float _movementSpead = 20f;
    [SerializeField] float _jumForce = 20f;
    [SerializeField] Transform _groundCheck;
    [SerializeField] LayerMask _ground;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis(HORIZONTAL_INPUT_NAME);
        float verticalInput = Input.GetAxis(VERTICAL_INPUT_NAME);

        _rigidBody.velocity = new Vector3(horizontalInput * _movementSpead, _rigidBody.velocity.y, verticalInput * _movementSpead);
        Debug.Log(string.Format("Is grounded: {0}", IsGrounded()));
        if (Input.GetButtonDown(JUMP_INPUT_BUTTON_NAME) && IsGrounded())
        {
            _rigidBody.velocity = new Vector3(_rigidBody.velocity.x, _jumForce, _rigidBody.velocity.z); // since we are only jumping, then we only need to set the Y value of the vector3 structure
        }
    }
    bool IsGrounded() => Physics.CheckSphere(_groundCheck.position, _groundCheckRadius, _ground.value);
}
