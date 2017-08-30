using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    float radius;
    float angle;
    public float distance;
    List<Body> ChildrenBodys = new List<Body>();
    SpriteRenderer spriteRenderer;
	public Transform ParentBody;
    BodyType type;

    // Use this for initialization
    void Start()
    {
		angle = 4f;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		
    }

    // Update is called once per frame
    void Update()
    {	
		OrbitParent(ParentBody);

    }

	void OrbitParent(Transform t){
		transform.RotateAround(t.position, Vector3.forward, angle/distance);
	}
}
