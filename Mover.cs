using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;        //Adds a Input feild in inspector to add an object into the script

        NavMeshAgent navMeshAgent;

        private void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {

            // if (Input.GetMouseButton(0))                                         //Checks if the left mouse button is clicked
            // {
            //     MoveToCursor();

            //  }
            UpdateAnimator();
        }


        public void MoveTo(Vector3 destination)
        {
            GetComponent<NavMeshAgent>().destination = destination;
            navMeshAgent.isStopped = false;
        }

        public void Stop()
        {
            navMeshAgent.isStopped = true;
        }

        private void UpdateAnimator()                               //Function to chnage the global velocity to local velocity as the animation only reads in local values
        {
            Vector3 velocity = navMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
        }
    }

}