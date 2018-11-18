using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

  //Editable Component Member Variables i.e. [SerializeField]
  [SerializeField]
  Transform m_target;

  //Editable Member Variables i.e [SerializeField]\
  [SerializeField]
  Vector3 m_offset;


  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (m_target)
    {
      FollowTarget();
    }
  }

  void FollowTarget()
  {
    transform.position = m_target.position + m_offset;
  }
}
