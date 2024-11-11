using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    // Public Variables
    public GameObject itemFeedbackObject;

    private void OnTriggerEnter2D(Collider2D other)
    {       
       
        if(other.transform.CompareTag("Player"))
        {
            Collect();
        }
    }

    private void Collect()
    {
            // Player picked me up!

            // Update the score
            GameManager.instance.UpdateScore(500);

            // Create Item Feedback Object
            GameObject.Instantiate(itemFeedbackObject, transform.position, Quaternion.identity);
            
            // Destroy This Object
            Destroy(this.gameObject);
    }
}
