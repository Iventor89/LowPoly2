using UnityEngine;

public class Interactible : MonoBehaviour
{
    public float radius = 3f;
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
