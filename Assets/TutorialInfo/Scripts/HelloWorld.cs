using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }
    float direction = 1;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0 || transform.position.y > 5f)
        {
            direction *= -1;
        }

        transform.Translate(0, 0.01f * direction, 0);
        transform.Rotate(0, 90/60f, 0);
    }
}
