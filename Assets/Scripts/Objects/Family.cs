using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru3- Yeni bir obje olu�turup bu objenin alt�na 10 adet child obje olu�turunuz. Child objelerimize rigidbody ekleyelim ve parent objemize att���m�z script ile
//child objelerimizdeki rigidbodyleri bir dizinin i�ine alal�m.Dizideki b�t�n rigidbodylerin usegravity de�erini false yapal�m.

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
