using Unity.VisualScripting;
using UnityEngine;

public class TargetMeat : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Floor")
        {
            Destroy(gameObject);
        }
    }
}