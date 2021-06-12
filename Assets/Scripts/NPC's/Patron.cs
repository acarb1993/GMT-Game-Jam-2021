using System;
using System.Collections.Generic;
using UnityEngine;

public class Patron : MonoBehaviour
{
    private List<RuneType> runes;
    private RuneType rune;

    // Start is called before the first frame update
    void Start()
    {
        runes = new List<RuneType>();

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

        Debug.Log("Yo dawg, let me get a " + rune + " rune. I'll take " + amount +  " of them.");
    }
}
