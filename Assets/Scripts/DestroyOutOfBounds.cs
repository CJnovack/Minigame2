using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float topBound = -15;
   // private float lowerBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < topBound)
        {
            Destroy(gameObject);
        }
        
        
    }
}
