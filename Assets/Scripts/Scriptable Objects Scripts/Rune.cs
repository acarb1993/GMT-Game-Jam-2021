using UnityEngine;

[CreateAssetMenu]
public class Rune : ScriptableObject
{
    public RuneType runeType;
    public string description;
    public Sprite artwork;
    public float cost;
}
