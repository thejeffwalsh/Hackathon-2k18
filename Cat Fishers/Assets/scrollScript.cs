using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollScript : MonoBehaviour
{
    private Rigidbody2D Rigid;
    private float m_Speed = 18.2f;
    private BoxCollider2D m_backgroundCollider;
    private float m_backgroundSize;
    Vector3 Startpos;
    public Renderer rend;

      void Start()
    {
        rend = GetComponent<Renderer>();
        Rigid = GetComponent<Rigidbody2D>();
        Rigid.velocity = new Vector2(0, m_Speed);

        //Startpos = transform.position;
    }


   /* void Update()
    {
        if (transform.position.y >=(2*rend.bounds.size.y)-1.5)
        {
            Vector2 BGoffset = new Vector2(0, m_backgroundSize * 2f * this.transform.localScale.y);

            transform.position = Startpos-Startpos;
        }
    }*/
}
