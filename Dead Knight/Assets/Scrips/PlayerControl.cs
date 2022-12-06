using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 2f;
    private Vector2 Target;
    public Vector3 Offset;

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
        }

        transform.position = Vector2.MoveTowards(transform.position, Target, speed * Time.deltaTime);
        
    }
}
