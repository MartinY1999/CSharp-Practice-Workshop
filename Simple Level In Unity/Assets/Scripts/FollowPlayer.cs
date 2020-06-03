using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
	void Start ()
	{
		
	}
    // if t.p = p.p only - FPS View
    void FixedUpdate ()
	{
	    transform.position = player.position + offset;
	}
}
