using System;
using System.Collections.Generic;
using UnityEngine;

public class Patron : MonoBehaviour
{
    private List<RuneType> runes;
    private RuneType rune;
    private ChatBubble chatbubble;

    // Start is called before the first frame update
    void Start()
    {
        runes = new List<RuneType>();
        chatbubble = transform.Find("Chat Bubble").GetComponent<ChatBubble>();

        // Get each type of rune the patron can ask for.
        foreach (RuneType type in Enum.GetValues(typeof(RuneType)))
        {
            runes.Add(type);
        }

        // Get a random rune and amount
        int index = UnityEngine.Random.Range(0, runes.Count);
        rune = runes[index];
        // TODO change from being hard coded numbers, only here for testing
        int amount = UnityEngine.Random.Range(1, 5);

        chatbubble.SetIcon(rune);
        chatbubble.SetText("Greetings Dwarf, I will purchase a " + rune + " rune. I'll take " + amount +  " of them.");
    }
}
