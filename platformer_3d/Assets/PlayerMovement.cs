using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody.velocity = new Vector3(0, 5, 0); // since we are only jumping, then we only need to set the Y value of the vector3 structure
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidBody.velocity = new Vector3(0, 0, 5); // since we are moving up, then we only need to set the Z value of the vector3 structure
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidBody.velocity = new Vector3(5, 0, 0); // since we are moving right, then we only need to set the YX value of the vector3 structure
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidBody.velocity = new Vector3(0, 0, -5); // since we are moving right, then we only need to set the YX value of the vector3 structure
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidBody.velocity = new Vector3(-5, 0, 0); // since we are moving right, then we only need to set the YX value of the vector3 structure
        }
    }
}
