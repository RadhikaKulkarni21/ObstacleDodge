using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xvalue = 0.01f;
    [SerializeField] float yvalue = 0f;
    [SerializeField] float zvalue = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xvalue, yvalue, zvalue);
    }
}
