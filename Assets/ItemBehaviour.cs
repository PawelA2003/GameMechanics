using UnityEngine;
using UnityEngine.UI;

public class ItemBehaviour : MonoBehaviour
{
    public Text interactionText;
    private bool isPlayerNear = false; 
    public Text CherryCounterText; 

    private void Update()
    {
        
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject); 
            GameManager.Instance.CherryCounter++; 
            GameManager.Instance.HasEatenFirstCherry = true; 

            CherryCounterText.text = "Cherry Counter: " + GameManager.Instance.CherryCounter.ToString();

            
            if (interactionText != null)
            {
                interactionText.text = "";
                interactionText.gameObject.SetActive(false); 
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" )
        {
            isPlayerNear = true; 

            
            if (interactionText != null && !GameManager.Instance.HasEatenFirstCherry)
            {
                interactionText.gameObject.SetActive(true);
                interactionText.text = "Should I eat this non Suspicous Cherry?!";
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isPlayerNear = false; 

            
            if (interactionText != null)
            {
                interactionText.text = "";
            }
        }
    }
}