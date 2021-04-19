using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class telepo : MonoBehaviour
    {
        public float speed = 1.0f;
        public Vector3 targetPos;


        // Start is called before the first frame update
        void Start()
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            targetPos = new Vector3(-15.18f, 4.956546f, 4.119892f);

        }

        // Update is called once per frame
        void Update()
        {


        }

        void OnCollisionEnter(Collision collision)
        {

            print("trigger");

            if (collision.gameObject.CompareTag("target"))
            {
                print("yep");

                transform.position = targetPos;

            }
        }
    }


   