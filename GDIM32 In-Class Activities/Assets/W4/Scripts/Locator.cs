using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance {  get; private set; }
    public W4Pigeon Player {  get; private set; }
    void Awake()
    {
        if (Instance != null&& Instance != this)
        {
            Destroy(this);
            return;
        }
        GameObject pigeon = GameObject.FindWithTag("Player");
        Player = pigeon.GetComponent<W4Pigeon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
