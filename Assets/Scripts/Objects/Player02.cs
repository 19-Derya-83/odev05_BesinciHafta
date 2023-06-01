using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru4- 2 ayrý objemiz olsun.Birinde bizim yazdýðýmýz bir script olsun diðerinde ise SphereCollider olsun. Kendi yazdýðýmýz script ile diðer objede var olan SphereCollidera
//ulaþýp isTrigger deðerini true, radius deðerini 3 yapalým.

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
