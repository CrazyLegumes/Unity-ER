using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetScroller : MonoBehaviour {

  // Editable Member Variables
  [SerializeField]
  public float m_scrollSpeed;

  // Hidden Member Variables
  private Vector2 savedOffset;

	// Use this for initialization
	void Start ()
  {
		
	}
	
	// Update is called once per frame
	void Update ()
  {
    float x = Mathf.Repeat(Time.time * m_scrollSpeed, 1);
    Vector2 offset = new Vector2(x, 0);
    //Vector2 
	}
}
