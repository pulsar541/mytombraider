using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy; 

	float _msek = 0;

    // Start is called before the first frame update
    void Start()
    {
      //  StartCoroutine(GenerateEnemy()); 
    }

    // Update is called once per frame
    void Update()
    {
        if (_enemy == null) {
			_enemy = Instantiate(enemyPrefab) as GameObject; 
			_enemy.transform.position = new Vector3(0, 1, 0);
			float angle = Random.Range(0, 360);
			_enemy.transform.Rotate(0, angle, 0);
		}


		_msek += Time.deltaTime;

		if(_msek > 15) {
			_msek = 0;
			_enemy = Instantiate(enemyPrefab) as GameObject; 
			_enemy.transform.position = new Vector3(0, 1, 0);
			float angle = Random.Range(0, 360);
			_enemy.transform.Rotate(0, angle, 0);			
		}
    }


/*
      private IEnumerator GenerateEnemy() { // Сопрограммы пользуются функциями IEnumerator.
		 
		_enemy = Instantiate(enemyPrefab) as GameObject; 
		_enemy.transform.position = new Vector3(0, 1, 0);
		float angle = Random.Range(0, 360);
		_enemy.transform.Rotate(0, angle, 0); 
		yield return new WaitForSeconds(5); // Ключевое слово yield указывает сопрограмме, когда следует остановиться.
		 
	}*/
}
