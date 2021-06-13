using UnityEngine;

public class RuneTable : MonoBehaviour
{
    [SerializeField] private Transform tableUI;
    private bool canCraft;

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            tableUI.gameObject.SetActive(true);
            canCraft = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            tableUI.gameObject.SetActive(false);
            canCraft = false;
        }
    }
}
