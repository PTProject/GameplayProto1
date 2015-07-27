using UnityEngine;
using System.Collections;

abstract class Item : FengShui {

	protected FSSystem home;

	protected virtual void Start () {}

	protected virtual void setInitValues() {}

	protected virtual void  FixedUpdate() {}

	protected virtual void Update () {
	}
}
