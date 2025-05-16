using UnityEngine;

public class Forsvinnvedhit : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Projectile"))
        {
       
            gameObject.SetActive(false);


		Destroy(gameObject);

         
        }
    }
}
