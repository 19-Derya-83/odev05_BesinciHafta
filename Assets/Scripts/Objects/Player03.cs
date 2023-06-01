using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru4- 2 ayr� objemiz olsun.Birinde bizim yazd���m�z bir script olsun di�erinde ise SphereCollider olsun. Kendi yazd���m�z script ile di�er objede var olan SphereCollidera
//ula��p isTrigger de�erini true, radius de�erini 3 yapal�m.

namespace Objects

{

    public class Player03 : MonoBehaviour
    {

        private SphereCollider _player03SphereCollider;

        public int radius;

        public bool isTrigger;

        private void Start()
        {

            _player03SphereCollider = GetComponent<SphereCollider>();

            Debug.Log($" Player03 isTrigger de�eri : {_player03SphereCollider.isTrigger}");
            Debug.Log($" Player03 radius de�eri : {_player03SphereCollider.radius}");


        }


    }

}
