using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("collision occured");
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.gray;
            //new tag each time player hits an obstacle
            gameObject.tag = "Hit";
        }
    }
}
