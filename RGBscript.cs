using UnityEngine;
using System.Collections;

public class RGBscript : MonoBehaviour {

	const float speed = 0.1f;
	float t = 0;
	int i = 0;
	Color[] colors = {  			Color.white,
						Color.red,
						Color.green,
						Color.blue,
						Color.cyan,
						Color.magenta,
						Color.yellow,
						Color.white };
	
	void Update () {
		t+=Time.deltaTime*speed;
		gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(colors[i], colors[i+1], t);

		if (t>1) {
			t=0;
			i++;
			if (i>=colors.Length-1) i=0;
		}
	}
}
