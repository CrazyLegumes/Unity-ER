using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {

  // Components
  [SerializeField]
  public Transform background1;

  // Editable Member Variables
  [SerializeField]
  public float m_scrollSpeed, m_tileSize;

  // Hidden Member Variables
  private Vector3 m_startPosition;
  private int m_backgroundCheck = 24;
  private Transform m_bg1, m_bg2, m_bg3;

	// Use this for initialization
	void Start ()
  {

    m_bg2 = Instantiate(background1, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 10), Quaternion.identity);
    m_bg1 = Instantiate(background1, new Vector3(this.transform.position.x + 24, this.transform.position.y, this.transform.position.z + 10), Quaternion.identity);
    m_startPosition = transform.position;

  }
	
	// Update is called once per frame
	void Update ()
  {

    float newPosition = Time.time * m_scrollSpeed;
    transform.position = m_startPosition + Vector3.right * newPosition;

    if (transform.position.x > m_backgroundCheck)
    {
      m_backgroundCheck += 24;

      Debug.Log(m_backgroundCheck);

      m_bg3 = m_bg2;
      m_bg2 = m_bg1;
      Destroy(m_bg3.gameObject);
      m_bg1 = Instantiate(background1, new Vector3(Mathf.Floor(this.transform.position.x + 24), this.transform.position.y, this.transform.position.z + 10), Quaternion.identity);
    }
		
	}
}
