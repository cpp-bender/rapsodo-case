using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private PlayerController playerController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<PlayerController>(out playerController))
        {
            Debug.Log("Congratulations");
        }
    }
}
