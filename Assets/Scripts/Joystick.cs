using System.Collections;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    [SerializeField]
    private float _PlayerMoveSpeed = 3;
    private bool _touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public Transform player;
    public Transform joystick_circle;
    public Transform joystick_outerCircle;
    public enum Axis
    {
        Vertical_and_Horizontal,
        Horizontal,
        Vertical
    };
    public Axis choosenAxis;

    public enum MoveType
    {
        Physics,
        Transform
    };
    public MoveType choosenMoveType;

    void Update()
    {
        inputCheck(); ;
    }

    void inputCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            joystick_circle.transform.position = pointA;
            joystick_outerCircle.transform.position = pointA;
            joystick_circle.GetComponent<Renderer>().enabled = true;
            joystick_outerCircle.GetComponent<Renderer>().enabled = true;
        }
        if (Input.GetMouseButton(0))
        {
            _touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            _touchStart = false;
        }
    }

    private void FixedUpdate()
    {
        if (_touchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            Vector2 axis = new Vector2(0, 0);
            if(choosenAxis == Axis.Vertical_and_Horizontal)
            {
                axis = direction;
            }
            else if(choosenAxis == Axis.Horizontal)
            {
                axis = new Vector2(direction.x, 0f);
            }
            else if(choosenAxis == Axis.Vertical)
            {
                axis = new Vector2(0f, direction.y);
            }

            Move(axis);
            joystick_circle.transform.position = new Vector2(pointA.x + axis.x, pointA.y + axis.y);
        }
        else
        {
            joystick_circle.GetComponent<Renderer>().enabled = false;
            joystick_outerCircle.GetComponent<Renderer>().enabled = false;
        }
    }
    void Move(Vector2 direction)
    {
        if(choosenMoveType == MoveType.Transform)
        {
            player.transform.Translate(direction * _PlayerMoveSpeed * Time.deltaTime);
        }
        else if(choosenMoveType == MoveType.Physics)
        {
            player.gameObject.GetComponent<Rigidbody2D>().AddForce(direction * _PlayerMoveSpeed);
        }
        
    }
}   


