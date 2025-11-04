using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    public float speed = 0.7f;
    private bool isChasing = false;
    private Vector3 playerPosition;

    public void StartChasing(Vector3 playerPosition)
    {
        isChasing = true;
        this.playerPosition = playerPosition;
    }
    public void StopChasing()
    {
        isChasing = false;
    }
    void Update()
    {
        if (isChasing)
        {
            Vector3 direction = (playerPosition - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
