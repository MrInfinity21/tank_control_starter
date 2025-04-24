using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _objectToSpawn;

    WaitForSeconds _spawnDelay = new WaitForSeconds(2f);
    
    Coroutine _currentCoroutine;
    void Start()
    {
        //_currentCoroutine = StartCoroutine(SpawnObjects());
        
        InvokeRepeating("InvokeFuntion", 2f, 1f);
    }

    void InvokeFuntion()
    {
        Debug.Log("Invoke the funtion");
    }
   

    IEnumerator SpawnObjects()
    {
        // Everything that happens up here will call immediately
        Debug.Log("Start coroutine");
        yield return _spawnDelay;
        
        //Everything that happens up here will occur after 5 seconds elapsed
        Instantiate(_objectToSpawn, transform.position, Quaternion.identity, transform);
        _currentCoroutine = StartCoroutine(SpawnObjects());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
          Debug.Log("Destroy coroutine");  
          Destroy(gameObject);
        }
    }
}
