using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour {

	public Transform firepoint;
	public GameObject fireball;

	public float shotdelay;
	private float shotdelaycounter;
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.L)){
			Instantiate(fireball,firepoint.position,firepoint.rotation);
			shotdelaycounter = shotdelay;
		}
		if(Input.GetKey(KeyCode.L)){
			shotdelaycounter-= Time.deltaTime;

			if(shotdelaycounter<=0){
				shotdelaycounter=shotdelay;
				Instantiate(fireball,firepoint.position,firepoint.rotation);
		}
}
}
}
