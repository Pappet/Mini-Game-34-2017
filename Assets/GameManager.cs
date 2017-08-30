using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public GameObject PlanetPrefab;

    public int PlanetCount;
    public int MoonCount;
    List<GameObject> Planets = new List<GameObject>();

    GameObject Sun;

    // Use this for initialization
    void Start()
    {
        Sun = Instantiate(PlanetPrefab);
		Sun.GetComponent<Body>().ParentBody = transform;
        if (PlanetCount > 0)
        {
            for (int i = 0; i < PlanetCount; i++)
            {
                GameObject g = Instantiate(PlanetPrefab);
				Planets.Add(g);
                g.GetComponent<Body>().ParentBody = Sun.transform;
                g.GetComponent<Body>().distance = i * PlanetCount +1;
                g.transform.position = new Vector3(transform.position.x + g.GetComponent<Body>().distance, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
