using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceSpawner : MonoBehaviour
{
  public static InstanceSpawner instance;


  //Editable Componenet Member Variables
  [SerializeField]
  GameObject[] m_floorPrefabPool;

  void Awake()
	{
		if(!instance){
      instance = this;
    } else {
      Destroy(gameObject);
    }

    DontDestroyOnLoad(gameObject);
  }

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
