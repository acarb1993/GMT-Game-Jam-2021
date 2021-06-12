using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    private SpriteRenderer bgSpriteRenderer;
    private SpriteRenderer iconSpriteRenderer;
    private TextMeshPro tmp;
    void Awake()
    {
        bgSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
        iconSpriteRenderer = transform.Find("Icon").GetComponent<SpriteRenderer>();
        tmp = transform.Find("Text").GetComponent<TextMeshPro>();
    }

    private void Start()
    {
    }

    public void SetText(string text)
    {
        tmp.SetText(text);
    }
}
