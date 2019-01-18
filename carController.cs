using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {


    public float carSpeed;
    public float maxPos = 2.2f;
    public GameObject Explosion;


    Vector3 position;
   public uiManager ui;

	// Use this for initialization
	void Start () {
      //  ui = GetComponent<uiManager>();
        position = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;

       position.x =  Mathf.Clamp(position.x, -2.2f, 2.2f);

            transform.position = position;
	}
     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemycar") {
            PlayerExplosion();
        Destroy (gameObject);
            ui.gameOverActivated();
    
        
    }
   
}
    void PlayerExplosion()
    {
        GameObject explosion = (GameObject)Instantiate (Explosion);
        explosion.transform.position = transform.position;
    }
}
