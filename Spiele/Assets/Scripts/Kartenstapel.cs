using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Kartenstapel : MonoBehaviour
{
    public List<GameObject> kartenstapel;
	public float kartenAbstand;
    public GameObject stapelposition;

    // Start is called before the first frame update
    void Start()
    {		
		int zufallszahl;
		System.Random rnd = new System.Random();
        // Reihenfolge der Karten bestimmen (Mischen)
		for (int lJZaehler = 0; lJZaehler < 3; lJZaehler++)
		{
			for (int lIZaehler = 0; lIZaehler < kartenstapel.Count; lIZaehler++)
			{
				zufallszahl = rnd.Next(kartenstapel.Count);
				if (zufallszahl != lIZaehler)
				{
					GameObject tmp = kartenstapel[lIZaehler];
					kartenstapel[lIZaehler] = kartenstapel[zufallszahl];
					kartenstapel[zufallszahl] = tmp;
				}
			}
		}

		// Karten nach Reihenfolge erstellen
		//stapelposition = gameObject.transform.Position;
		for (int lIZaehler = 0; lIZaehler < kartenstapel.Count; lIZaehler++)
		{
			// Debug.Log(stapelposition.transform.position);
			Instantiate(kartenstapel[lIZaehler], stapelposition.transform.position, Quaternion.identity, stapelposition.transform);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
//	public static IList<GameObject> Swap<GameObject>(this IList<GameObject> list, int indexA, int indexB)
//	{
//		GameObject tmp = list[indexA];
//		list[indexA] = list[indexB];
//		list[indexB] = tmp;
//		return list;
//	}
}
