using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru3- Yeni bir obje oluþturup bu objenin altýna 10 adet child obje oluþturunuz. Child objelerimize rigidbody ekleyelim ve parent objemize attýðýmýz script ile
//child objelerimizdeki rigidbodyleri bir dizinin içine alalým.Dizideki bütün rigidbodylerin usegravity deðerini false yapalým.

namespace Objects

{

    public class Family : MonoBehaviour
    {

        public Rigidbody[] _familyRigidBodies;

        private void Start()
        {

            _familyRigidBodies = GetComponentsInChildren<Rigidbody>();

            foreach (var ChildrenRigidbody in _familyRigidBodies)
            {

                ChildrenRigidbody.useGravity = false;

            }

        }

    }

}
