using UnityEngine;
using System.Collections.Generic;

public class Index : MonoBehaviour
{
    public static Index Instance;
    public Dictionary<string, int> BinaryIndex;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;

        }

        BinaryIndex = new Dictionary<string, int> {
            {"A", 00001 },
            {"B", 00010 },
            {"C", 00011 },
            {"D", 00100 },
            {"E", 00101 },
            {"F", 00110 },
            {"G", 00111 },
            {"H", 01000 },
            {"I", 01001 },
            {"J", 01010 },
            {"K", 01011 },
            {"L", 01100 },
            {"M", 01101 },
            {"N", 01110 },
            {"O", 01111 },
            {"P", 10000 },
            {"Q", 10001 },
            {"R", 10010 },
            {"S", 10011 },
            {"T", 10100 },
            {"U", 10101 },
            {"V", 10110 },
            {"W", 10111 },
            {"X", 11000 },
            {"Y", 11001 },
            {"Z", 11010 }
        };
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
