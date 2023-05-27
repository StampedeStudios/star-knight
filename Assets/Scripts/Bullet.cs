using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 12f;
    Vector2 max;
    Vector2 min;

    // Start is called before the first frame update
    void Start()
    {
        // calcolo margine superiore piu extra
        max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

    }

    // Update is called once per frame
    void Update()
    {
        // sposto il proiettile verso l alto dello schermo
        transform.position = transform.position + transform.up * speed * Time.deltaTime;

        // distruggo il proiettile quando raggiungo il limite imposto
        if (transform.position.y > max.y | transform.position.y < min.y | transform.position.x > max.x | transform.position.x < min.x)
        {
            Destroy(gameObject);
        }

    }
}
