using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBehavior : MonoBehaviour
{
    public int Value = -1;
    public CardSuits Suit;
    public CardRoles Role;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        
    }

    void OnMouseDrag()
    {
        // get current mouse position
        Vector3 mousePos = Input.mousePosition;
        // apply mouse position to world position
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        // change z accordingly
        worldPosition.z = gameObject.transform.position.z;
        // apply new position to gameObject
        gameObject.transform.position = worldPosition;
    }


    void OnMouseExit()
    {
     
    }
}
