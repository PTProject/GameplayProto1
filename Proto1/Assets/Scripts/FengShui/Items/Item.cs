using UnityEngine;
using System.Collections;

abstract class Item : FengShui {

	protected FSHome home;

	protected virtual void setInitValues() {}

	protected virtual void  FixedUpdate() {}

	public virtual void deploy() {}

	public virtual void HomeEffect() {}
}
