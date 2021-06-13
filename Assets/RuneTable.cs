using UnityEngine;

public class RuneTable : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Transform tableUI;


    void Start()
    {
        tableUI = player.transform.Find("Table_UI");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            tableUI.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            tableUI.gameObject.SetActive(false);
        }
    }
}
