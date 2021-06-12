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

    public void SetText(string text)
    {
        tmp.SetText(text);
    }

    // Displays the icon of the given rune type in the chat bubble
    public void SetIcon(RuneType rt)
    {
        if(rt == RuneType.Blank)
            iconSpriteRenderer.sprite = Resources.Load<Sprite>("Sprites/Rune");
        else
            iconSpriteRenderer.sprite = Resources.Load<Sprite>("Sprites/"+rt+"-Rune");
    }
}
