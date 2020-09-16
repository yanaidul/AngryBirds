using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public Canvas text;
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
    }

    private void Update()
    {
        if (gameController.Enemies.Count == 0)
        {
            text.enabled = true;
        }
    }


}
