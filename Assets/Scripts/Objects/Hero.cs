using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru5 - 2 ayr� objemiz ve her ikisine att���m�z 2 ayr� scriptimiz olsun. Bu iki scripte int, string ve bool de�i�kenler ve bu de�i�kenlerle alakal� metot olu�tural�m.
//En son bu objelerden birbirine ve birbirinin i�indeki scriptlere ula��p de�i�kenlerin de�erlerini de�i�tirelim. Ve metotlar�n� kullan�p consola de�i�tirdi�imiz de�i�kenleri yazal�m.
//(Burda size b�rak�yorum scriptleri nas�l olu�turaca��n�z� vs)

namespace Objects

{

    public class Hero : MonoBehaviour
    {
        public int can;

        public string name;

        public bool status;

        public GameObject enemyGameObject;

        private Enemy _enemy;

        private void Start()
        {

            HeroPlayer( 12, "Bella");

            Debug.Log($"{name} isimli oyuncunun {can} adet can� var ve status� {status} 'dur.");

            _enemy = enemyGameObject.GetComponent<Enemy>();

            _enemy.EnemyPlayer( 15, "Victor");

            Debug.Log($"{_enemy.name} isimli oyuncunun {_enemy.can} adet can� var ve status� {status} 'dur.");

        }

        public void HeroPlayer( int heroCan, string heroName)

        {
            can = heroCan;
            name = heroName;

            if ( heroCan <= 10)
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
