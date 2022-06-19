
using UnityEngine;

public class PLayercollision : MonoBehaviour
{
   public playermovement movement;
   
    // Start is called before the first frame update
    
    // Update is called once per frame
    void OnCollisionEnter (Collision collisionInfo)

    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
