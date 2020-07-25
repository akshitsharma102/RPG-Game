using UnityEngine;
using RPG.MoveIt;
using System;
using RPG.Combact;

namespace RPG.Control
{
    public class ChracterController : MonoBehaviour
    {
        private void Update()
        {
            if(IntractWithCombact()) return;
            IntractWithMovement();
        }

        private bool IntractWithCombact()
        {
            RaycastHit[] hits = Physics.RaycastAll(GetMouseRay());
            foreach(RaycastHit hit in hits)
            {
                CombatTarget target = hit.transform.GetComponent<CombatTarget>();
                if (target == null) continue;

                if(Input.GetMouseButtonDown(0))
                {
                    GetComponent<Fighter>().Attack(target);
                }
                return true;
            }
            return false;
        }

        private void IntractWithMovement()
        {
            if (Input.GetMouseButton(0))
            {
                MovetoCursor();
            }
        }
        private void MovetoCursor()
        {
            Ray ray = GetMouseRay();
            RaycastHit hit;
            bool hashit = Physics.Raycast(ray, out hit);
            if (hashit == true)
            {
                GetComponent<Mover>().MoveTo(hit.point);
            }

        }

        private static Ray GetMouseRay()
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }

}