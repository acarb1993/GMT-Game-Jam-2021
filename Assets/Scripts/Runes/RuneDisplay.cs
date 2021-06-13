using UnityEngine;

public class RuneDisplay : MonoBehaviour
{
    [SerializeField] private Rune rune;
    private SpriteRenderer sr;
    public RuneType type;

    void Awake()
    {
        type = rune.runeType;
    }
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = rune.artwork;
    }
}
