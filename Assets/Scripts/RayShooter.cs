using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RayShooter : MonoBehaviour
{

    // Start is called before the first frame update

    void Start()
    {
       // _camera = GetComponent<Camera>();
       // Cursor.lockState = CursorLockMode.Locked;
       // Cursor.visible = false;

	   //soundSource = GetComponent<AudioSource>(); 
 
    }

	const float piOver180 = (float)Mathf.PI  /180.0f;

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetMouseButtonDown(0) 
			/*&& EventSystem.current.IsPointerOverGameObject()*/)
    	{ 
			;
    		Vector3 point = transform.position;   
			float angleRad = transform.eulerAngles.y * piOver180 ; 
    		Ray ray = new Ray(transform.position, new Vector3(Mathf.Sin(angleRad),0,Mathf.Cos(angleRad))); 
    		RaycastHit hit;
    		if(Physics.Raycast(ray, out hit)) {
    			GameObject hitObject = hit.transform.gameObject;
    			ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
    			if(target != null ) {
    				 //Debug.Log("Target Hit " + hit.point);
    				target.ReactToHit();
					//Messenger.Broadcast(GameEvent.ENEMY_HIT);
    			}
    			else {
    				StartCoroutine(SphereIndicator(hit.point));
    			}
    			
    		} 
    	}
        
    }

    private IEnumerator SphereIndicator(Vector3 pos) { // Сопрограммы пользуются функциями IEnumerator.
		GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere.transform.position = pos;
		yield return new WaitForSeconds(10); // Ключевое слово yield указывает сопрограмме, когда следует остановиться.
		Destroy(sphere); // Удаляем этот GameObject и очищаем память.
	}


	void OnGUI() {
		//int size = 12;
		//float posX = _camera.pixelWidth/2 - size/4;
		//float posY = _camera.pixelHeight/2 - size/2;
		//GUI.Label(new Rect(posX, posY, size, size), "*"); //Команда GUI.Label() отображает на экране символ.
	}
}
