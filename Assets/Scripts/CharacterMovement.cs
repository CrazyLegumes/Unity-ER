using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

  //Editable Component Member Varaibles

  //Hidden Member Variables

  //Editable Member Variables
  [SerializeField]
  float m_runSpeed;

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    Travel();
  }

	//Fake Move Boy
	void Travel()
	{
    Vector3 myPos = transform.position;
    myPos.x += Time.deltaTime * m_runSpeed;
    transform.position = myPos;
  }
}
