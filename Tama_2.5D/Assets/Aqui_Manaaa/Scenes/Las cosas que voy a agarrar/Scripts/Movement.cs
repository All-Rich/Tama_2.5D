using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private Rigidbody2D tikki;

    private bool left;

    private bool right;

    private float horizontalMove;

    [SerializeField]private float speed = 5f;

    public float fuerzaSalto;
    // Start is called before the first frame update
    void Start()
    {
        tikki = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        transform.Translate(Vector2.right * (Time.deltaTime * speed));
    }
    public void ButtonJump()
    {
        tikki.AddForce(new Vector2(0, fuerzaSalto));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Salida")
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Muerte")
        {
            SceneManager.LoadScene(0);
        }

    }
}
