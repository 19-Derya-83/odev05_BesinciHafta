using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru4- 2 ayrý objemiz olsun.Birinde bizim yazdýðýmýz bir script olsun diðerinde ise SphereCollider olsun. Kendi yazdýðýmýz script ile diðer objede var olan SphereCollidera
//ulaþýp isTrigger deðerini true, radius deðerini 3 yapalým.

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

            Debug.Log($" Player03 isTrigger deðeri : {_player03SphereCollider.isTrigger}");
            Debug.Log($" Player03 radius deðeri : {_player03SphereCollider.radius}");


        }


    }

}
