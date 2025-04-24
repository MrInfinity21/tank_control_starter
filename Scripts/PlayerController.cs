using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
    private Vector2 _inputVector;
    [SerializeField] private float _movementSpeed = 100f;
    [SerializeField] private Weapon _equippedWeapon;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private float _jumpForce = 100f;
    private Vector3 jump;
    private Rigidbody _rigidbody;
    private bool _isGrounded = true;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        jump = new Vector3(0, 2f, 0);
    }

    public void SayHello()
    {
        Debug.Log("Hi!");
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire");
            if (_equippedWeapon)
            {
                _equippedWeapon.Shoot();
            }
        }
        _inputVector = new Vector2(x, y);
      
        transform.Rotate(Vector3.up, _inputVector.x * Time.deltaTime * _rotationSpeed);
        transform.Translate(0, 0, (_inputVector.y * Time.deltaTime * _movementSpeed));

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _isGrounded = false; 
            _rigidbody.AddForce(jump * _jumpForce, ForceMode.Impulse);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        // If the player collides with something tagged as "Ground", set isGrounded to true
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true; // Player is back on the ground
        }
    }
    void OnCollisionStay(Collision collision)
    {
        // Ensure the player remains grounded when touching the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
}
