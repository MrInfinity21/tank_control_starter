using UnityEngine;

public class SphereCollision : MonoBehaviour
{
 private void OnCollisionEnter(Collision other)
 {
  Debug.Log(other.gameObject.name + "Sphere Landed");
  
 }

 private void OnCollisionExit(Collision other)
 {
  Debug.Log("Sphere Exited");
 }
}
