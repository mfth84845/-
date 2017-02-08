using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOperation : Operation {
	public Animator anim;
	public string state;

	public override void Execute ()
	{
		anim.Play (state);	
	}

	public override bool IsOver {
		get 
		{
			return true;
		}
	}
}
