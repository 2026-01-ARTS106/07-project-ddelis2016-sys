using UnityEngine;

public class destroy : MonoBehaviour
{
    // Tag your player object as "FPSController" in the Inspector
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FPSController"))
        {
            // SetActive(false) hides the object and stops its scripts
            gameObject.SetActive(false);

            // Use Destroy(gameObject) instead if you never want it back
        }
    }
}
