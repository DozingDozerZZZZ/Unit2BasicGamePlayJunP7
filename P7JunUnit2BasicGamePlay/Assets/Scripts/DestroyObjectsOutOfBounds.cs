using UnityEngine;

public class DestroyObjectsOutOfBounds : MonoBehaviour
{
    private float TopBound = 30;
    private float lowerbound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }
    }
}
