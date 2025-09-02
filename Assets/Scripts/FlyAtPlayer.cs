using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float maxDistanceDelta = 10f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
   
    void Start()
    {
        playerPosition = player.transform.position;      
    }

    void Update()
    {        
        MoveToPlayer();

        DestroyOnReach();
    }

    void MoveToPlayer()
    {
        //this will fly towards the player
        //move towards = transfrom.pos = current pos of projectile
        //player position = target
        //maxDistanceDelta = every frame we want to move 1f towards the player
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * maxDistanceDelta);
    }

    void DestroyOnReach()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        } 
    }

}
