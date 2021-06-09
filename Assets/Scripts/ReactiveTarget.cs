using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
	[SerializeField] private  AudioSource soundSource;  
    [SerializeField] private  AudioClip destroySound; 

    //

	public void ReactToHit() 
	{ 
		WanderingAI behavior = GetComponent<WanderingAI>();
		if(behavior != null) {
			behavior.SetAlive(false);
 
			soundSource.PlayOneShot(destroySound);
		}
		StartCoroutine(Die());
	}
	private IEnumerator Die() 
	{  
		this.transform.Rotate(-75, 0, 0);
		yield return new WaitForSeconds(1.5f);
		Destroy(this.gameObject); 
	}
}
