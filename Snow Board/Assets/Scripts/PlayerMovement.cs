using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _torqueAmount;
    private Rigidbody2D rb;
    private int _right = 0;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        getkey();
    }
    void getkey()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _right = 1;
            StartCoroutine(TimeReset());
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _right = -1;
            StartCoroutine(TimeReset());
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        if (_right == 1)
        {
            rb.AddTorque(-_torqueAmount -Time.deltaTime);
        }
       else if (_right == -1) 
        {
            rb.AddTorque(_torqueAmount + Time.deltaTime);
        }
        
    }
    IEnumerator TimeReset()
    {
        yield return new WaitForSeconds(0.3f);
    }
}

