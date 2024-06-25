using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameManager.Instance.player.SetIsGrounded(true);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameManager.Instance.player.SetIsGrounded(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "10M":
                GameManager.Instance.startScroll?.Invoke();
                break;
            case "Death":
                Debug.LogError("Á×À½");
                break;
        }
    }

}
