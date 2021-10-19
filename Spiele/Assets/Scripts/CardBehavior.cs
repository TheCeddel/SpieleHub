using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBehavior : MonoBehaviour
{
    public int Wert = -1;
    public Kartenfarben Farbe;
    public Kartenrolle Rolle;
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
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        worldPosition.z = gameObject.transform.position.z;
        gameObject.transform.position = worldPosition;
    }


    void OnMouseExit()
    {
     
    }
}
