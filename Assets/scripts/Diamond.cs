using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit detected with: " + other.name);

        if (other.CompareTag("Player") || other.GetComponent<CharacterController>() != null)
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(1);
            }
            Destroy(gameObject);
        }
    }
}