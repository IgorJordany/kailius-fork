using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var game = (GameManager) GameObject.FindObjectOfType (typeof(GameManager));
        Debug.Log(game.mobile);
        gameObject.SetActive(game.mobile);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
