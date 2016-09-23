using UnityEngine;
using System.Collections;

public class KinematicSeek : MonoBehaviour {

	Move move;

	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (move.mov_velocity.magnitude > 0)
        {
            Vector3 move1 = new Vector3(1.0f, 0.0f, 1.0f);
            // TODO 5: Set movement velocity to max speed in the direction of the target
          //  move.mov_velocity = move1 * move.max_mov_velocity;
        }
    }
}
