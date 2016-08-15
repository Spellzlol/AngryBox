using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {
    
    public GameObject bodyObject;
    public Vector2 force;

    private Rigidbody2D body;

    void Start() {
        body = bodyObject.GetComponent<Rigidbody2D>();
    }

    public void pushObject () {
        body.AddForce(force);
    }
}
