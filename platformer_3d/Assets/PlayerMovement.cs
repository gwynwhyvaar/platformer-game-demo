using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    const string JUMP_INPUT_BUTTON_NAME = "Jump";
    const string HORIZONTAL_INPUT_NAME = "Horizontal";
    const string VERTICAL_INPUT_NAME = "Vertical";

    private Rigidbody _rigidBody;
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

        _rigidBody.velocity = new Vector3(horizontalInput * 5f, _rigidBody.velocity.y, verticalInput * 5f);
        if (Input.GetButtonDown(JUMP_INPUT_BUTTON_NAME))
        {
            _rigidBody.velocity = new Vector3(_rigidBody.velocity.x, 5, _rigidBody.velocity.z); // since we are only jumping, then we only need to set the Y value of the vector3 structure
        }
    }
}
