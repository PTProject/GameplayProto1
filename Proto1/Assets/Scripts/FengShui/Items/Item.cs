using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Item : FengShui {

	protected FSHome home;
	protected List<Item> Connection;

	protected override abstract void Start ();

	protected virtual void setInitValues() {}

	protected virtual void  FixedUpdate() {}

	public virtual void deploy() {}

	public virtual void HomeEffect() {}


	
}
