using UnityEngine;

public class RuneDisplay : MonoBehaviour
{
    [SerializeField] private Rune rune;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = rune.artwork;
    }
}
