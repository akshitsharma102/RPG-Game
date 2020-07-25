using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.MoveIt
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;

        void Start()
        {

        }


        void Update()
        {
            //if (Input.GetMouseButton(0))
            //{
            //  MovetoCursor();
            // }
            UpateAnimator();
        }


        public void MoveTo(Vector3 destination)
        {
            GetComponent<NavMeshAgent>().destination = destination;
        }

        private void UpateAnimator()
        {
            Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
            Vector3 LocalVelocity = transform.InverseTransformDirection(velocity);
            float speed = LocalVelocity.z;
            GetComponent<Animator>().SetFloat("ForwardSpeed", speed);
        }
    }

}