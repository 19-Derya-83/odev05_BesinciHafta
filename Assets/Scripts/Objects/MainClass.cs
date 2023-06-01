using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Sorular

//Soru1- Bir cube oluþturup içine attýðýmýz bir script ile cube’nin boxcolliderinin isTrigger deðerini true, radius deðerini 2 yapýnýz ve bu deðerleri consola yazdýrýnýz.

//Soru2- Soru1 deki objeye bir Rigidbody componenti ekleyip ayný scriptten bu Rigidbody compenentine ulaþýp mass deðerini 10, drag deðerini 5 yapýnýz ve konsolda gösteriniz.

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

            Debug.Log($" Player01 isTrigger deðeri : {_player01BoxCollider.isTrigger = true}");

            #endregion

            #region Cevap 02

            _player01RigidBody = GetComponent<Rigidbody>();

            _player01RigidBody.mass = 10;
            _player01RigidBody.drag = 5;

            #endregion

        }

    }

}
