using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Control;


    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;


        void LateUpdate()
        {
            transform.position = target.position;
        }
    }
