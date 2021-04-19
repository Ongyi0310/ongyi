using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class yolojustmove : MonoBehaviour

{

    public float speed = 6.0F;

    public float jumpSpeed = 8.0F;

    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;





    void Start()

    {

        Cursor.lockState = CursorLockMode.Locked;

    }



    void Update()

    {

        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded) // detecting gameobject

        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // 物件取的移動座標

            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed; //*= assembling the parameter "movedirection = movedirection*speed

            if (Input.GetButton("Jump"))

                moveDirection.y = jumpSpeed;



        }

        moveDirection.y -= gravity * Time.deltaTime; //-= assembling the parameter "y-Axis movedirection = movedirection-gravity * Time.deltaTime

        // Time.deltaTime是一個唯讀的浮點數值變數, 存放的是從上一個frame播放到目前的frame所花費的秒數, 我們常用Time.deltaTime來延遲某物件的transform

        controller.Move(moveDirection * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.Escape))

            Cursor.lockState = CursorLockMode.None;

    }

}
