using UnityEngine;
using System.Collections;

public class EnemyCar : MonoBehaviour {
  
    public float speed = 8f;
    public GameObject explosion;
    public GameObject playerExplosion;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
	
	}
}
