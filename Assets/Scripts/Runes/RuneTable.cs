using UnityEngine;

public class RuneTable : MonoBehaviour
{
    [SerializeField] private Transform tableUI;
    [SerializeField] private GameObject player;
    private Inventory inv;
    public bool CanCraft { get; set; }

    void Start()
    {
        CanCraft = false;
        inv = player.GetComponent<Inventory>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            tableUI.gameObject.SetActive(true);
            CanCraft = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            tableUI.gameObject.SetActive(false);
            CanCraft = false;
        }
    }

    public void AddToPlayerInventory(RuneType type, int amt)
    {
        inv.addToInventory(type, amt);
    }
}
