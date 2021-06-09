using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    [SerializeField] private Transform target;

    public float rotSpeed = 1.5f;

    private float _rotY;
    private Vector3 _offset;
    // Start is called before the first frame update
    void Start()
    {
        _rotY = transform.eulerAngles.y;
        _offset = target.position - transform.position;

    }

    void LateUpdate()
    {
        float horInput = Input.GetAxis("Horizontal");
       // if (horInput != 0)
      //  { // Медленный поворот камеры при помощи клавиш со стрелками…
           // _rotY += horInput * rotSpeed;
      //  }
      //  else
      //  {
            _rotY += Input.GetAxis("Mouse X") * rotSpeed * 3; // или быстрый поворот с помощью мыши.
     //   }
        Quaternion rotation = Quaternion.Euler(0, _rotY, 0);
        transform.position = target.position - (rotation * _offset);  //
        transform.LookAt(target);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
