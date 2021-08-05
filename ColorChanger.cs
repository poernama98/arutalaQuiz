using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Material mc;
    public float timeToChange = 2f;
    private float timeSinceChange = 0f;

    private void Awake()
    {
        mc = GetComponent<Renderer>().material;

    }

    private void Update()
    {
        timeSinceChange += Time.deltaTime;

        if (mc.color == Color.black && timeSinceChange >= timeToChange)
        {
            Color white = new Color(1, 1, 1);
            mc.color = Color.white;
            timeSinceChange = 0f;
        }

        else if (mc.color == Color.white && timeSinceChange >= timeToChange)
        {
            Color white = new Color(0, 0, 0);
            mc.color = Color.black;
            timeSinceChange = 0f;
        }
    }
}

