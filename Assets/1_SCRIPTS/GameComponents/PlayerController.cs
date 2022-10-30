using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using SafeZone;

public class PlayerController : MonoBehaviour
{

    private UnityAction movementAction;
    // Start is called before the first frame update
    void Start()
    {
        movementAction += OrganizeKeyInputs;
    }

    // Update is called once per frame
    void Update()
    {
        movementAction();
    }
    public void OrganizeKeyInputs()
    {
        //Forward backward movement cannot be  at the same time.
        if (Input.GetKey(KeyCode.W))
        {
            MoveIt(KeyCode.W);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveIt(KeyCode.S);
        }

        //Horizontal is also cannot be.
        if (Input.GetKey(KeyCode.D))
        {
            MoveIt(KeyCode.D);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            MoveIt(KeyCode.A);
        }
    }
    private void MoveIt(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case KeyCode.W:
                transform.position = transform.position + (transform.forward * Time.deltaTime * GameManager.Instance.GetGameSettings().playerMoveSpeed);
                break;
            case KeyCode.S:
                transform.position = transform.position - (transform.forward * Time.deltaTime * GameManager.Instance.GetGameSettings().playerMoveSpeed / 2f);
                break;
            case KeyCode.D:
                RotateAngle(KeyCode.D);
                break;
            case KeyCode.A:
                RotateAngle(KeyCode.A);
                break;
        }
    }
    private void RotateAngle(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case KeyCode.D:
                Vector3 newRotationD = new Vector3(0,(GameManager.Instance.GetGameSettings().playerRotateSensivity), 0);
                transform.Rotate(newRotationD);
                break;
            case KeyCode.A:
                Vector3 newRotationA = new Vector3(0,-(GameManager.Instance.GetGameSettings().playerRotateSensivity), 0);
                transform.Rotate(newRotationA);
                break;
        }

    }
}
