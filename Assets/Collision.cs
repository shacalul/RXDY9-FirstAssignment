using UnityEngine;

public class Collision : MonoBehaviour
{
   public GameObject destroyedVersion;
   
   //public GameObject destroyedVersion;
  private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("enemy"))
      {
         Debug.Log("enter");
         var o = other.gameObject;
         Instantiate(destroyedVersion, o.transform.position, o.transform.rotation);
         other.gameObject.GetComponent<MeshRenderer>().enabled=false;
      }
   }

  private void OnTriggerStay(Collider other)
   {
      if (other.gameObject.CompareTag("enemy"))
      {
         Debug.Log("stay");
      }
   }

  private void OnTriggerExit(Collider other)
   {
      if (other.gameObject.CompareTag("enemy"))
      {
         Debug.Log("exit");
         other.gameObject.GetComponent<MeshRenderer>().enabled=true;
      }
   }
}
