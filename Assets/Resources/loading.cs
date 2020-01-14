using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform LoadingBar;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	// Update is called once per frame
	void Update () {
	if (currentAmount &lt; 100) {
	currentAmount += speed * Time.deltaTime;
	Debug.Log ((int)currentAmount);
	} else {
	Application.LoadLevel (&quot;main_menu&quot;);
	}
	LoadingBar.GetComponent&lt;Image&gt; ().fillAmount = currentAmount / 100;
	}
}
