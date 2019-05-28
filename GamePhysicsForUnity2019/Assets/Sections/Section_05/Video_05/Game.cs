﻿using UnityEngine;
namespace RMC.UnityGamePhysics.Sections.Section05
{
	public class Game : MonoBehaviour
	{
		protected void Awake()
		{
			Debug.Log("Awake");
		}
		protected void Start()
		{
			//Debug.Log("Start");
		}
		protected void FixedUpdate()
		{
		}
		protected void OnTriggerEnter(Collider collider)
		{
			Debug.Log("OnTriggerEnter: " + collider.gameObject.name);
		}
		protected void OnCollisionEnter(Collision collision)
		{
			//Debug.Log("OnCollisionEnter: " + collision.gameObject.name);
		}
		protected void Update()
		{
		}
		protected void OnDestroy()
		{
			Debug.Log("OnDestroy");
		}
	}
}