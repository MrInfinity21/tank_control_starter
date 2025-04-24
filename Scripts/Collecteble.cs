using System;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [Header("Collectable Details")]
    [SerializeField] private int _scoreAmount = 1;
    [SerializeField] private float _rotationSpeed = 10f;
    
    private void Update()
    {
        
        transform.Rotate(0, 1 * _rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.GetInstance().AddScore(_scoreAmount);
            Destroy(gameObject);
        }
    }
}
