using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru4- 2 ayr� objemiz olsun.Birinde bizim yazd���m�z bir script olsun di�erinde ise SphereCollider olsun. Kendi yazd���m�z script ile di�er objede var olan SphereCollidera
//ula��p isTrigger de�erini true, radius de�erini 3 yapal�m.

namespace Objects
{

    public class Player02 : MonoBehaviour
    {
        public GameObject player03GameObject;

       private Player03 _player03;

        private void Start()
        {

            _player03 = player03GameObject.GetComponent<Player03>();

            _player03.isTrigger = true;
            _player03.radius = 3;

        }

    }

}
