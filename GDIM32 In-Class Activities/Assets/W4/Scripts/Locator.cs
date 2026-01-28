using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance {  get; private set; }
    public W4Pigeon player {  get; private set; }
    void Awake()
    {
        if (Instance != null&& Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
        GameObject pigeon = GameObject.FindWithTag("Player");
        player = pigeon.GetComponent<W4Pigeon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
