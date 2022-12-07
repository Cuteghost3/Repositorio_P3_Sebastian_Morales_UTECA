using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 2f;
    private Vector2 Target;
    public Vector3 Offset;
    private bool mieandoDerecha = true;

    private void Aweke()
    {
        Target = new Vector2(-4, Offset.y);
    }
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Target = new Vector2(mousePos.x, Offset.y);
            Girar();
        }

        transform.position = Vector2.MoveTowards(transform.position, Target, speed * Time.deltaTime);
        
    }

    private void Girar()
    {
        mieandoDerecha = !mieandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}
