using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru5 - 2 ayr� objemiz ve her ikisine att���m�z 2 ayr� scriptimiz olsun. Bu iki scripte int, string ve bool de�i�kenler ve bu de�i�kenlerle alakal� metot olu�tural�m. En son bu objelerden birbirine ve birbirinin i�indeki scriptlere ula��p de�i�kenlerin de�erlerini de�i�tirelim. Ve metotlar�n� kullan�p consola de�i�tirdi�imiz de�i�kenleri yazal�m.
//(Burda size b�rak�yorum scriptleri nas�l olu�turaca��n�z� vs)

namespace Objects

{

    public class Enemy : MonoBehaviour
    {
        public int can;

        public string name;

        public bool status;

        public GameObject heroGameObject;

        private Hero _hero;

        private void Start()
        {

            EnemyPlayer(10, "Evil");
            Debug.Log($"{name} isimli oyuncunun {can} adet can� var ve status� {status} 'dur.");

            _hero = heroGameObject.GetComponent<Hero>();

            _hero.HeroPlayer(8, "Angel");

            Debug.Log($"{_hero.name} isimli oyuncunun {_hero.can} adet can� var ve status� {status} 'dur.");

        }

        public void EnemyPlayer(int enemyCan, string enemyName)

        {
            can = enemyCan;
            name = enemyName;

            if (enemyCan <= 10)
            {

                status = false;

            }

            else

            {

                status = true;

            }

        }

        
    }

}
