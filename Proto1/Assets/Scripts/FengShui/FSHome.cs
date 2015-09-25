using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSHome : FengShui {

	List<Item> FSinterior;
	protected float radius;
	
	protected override void Start () {
		base.Start ();
		FSinterior = new List<Item> ();
	}

	protected override void Update () {

	}

	public void add (Item item){
		FSinterior.Add (item);
	}
}
