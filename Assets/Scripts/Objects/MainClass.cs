using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Sorular

//Soru1- Bir cube olu�turup i�ine att���m�z bir script ile cube�nin boxcolliderinin isTrigger de�erini true, radius de�erini 2 yap�n�z ve bu de�erleri consola yazd�r�n�z.

//Soru2- Soru1 deki objeye bir Rigidbody componenti ekleyip ayn� scriptten bu Rigidbody compenentine ula��p mass de�erini 10, drag de�erini 5 yap�n�z ve konsolda g�steriniz.

#endregion

namespace Objects

{
    public class MainClass : MonoBehaviour
    {
        private BoxCollider _player01BoxCollider;

        public Rigidbody _player01RigidBody;

        //public Rigidbody [] _familyRigidBodies;


        private void Start()
        {
            #region Cevap 01

            _player01BoxCollider = GetComponent<BoxCollider>();

            Debug.Log($" Player01 isTrigger de�eri : {_player01BoxCollider.isTrigger = true}");

            #endregion

            #region Cevap 02

            _player01RigidBody = GetComponent<Rigidbody>();

            _player01RigidBody.mass = 10;
            _player01RigidBody.drag = 5;

            #endregion

        }

    }

}
