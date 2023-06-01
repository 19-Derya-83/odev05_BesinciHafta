using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru5 - 2 ayrý objemiz ve her ikisine attýðýmýz 2 ayrý scriptimiz olsun. Bu iki scripte int, string ve bool deðiþkenler ve bu deðiþkenlerle alakalý metot oluþturalým.
//En son bu objelerden birbirine ve birbirinin içindeki scriptlere ulaþýp deðiþkenlerin deðerlerini deðiþtirelim. Ve metotlarýný kullanýp consola deðiþtirdiðimiz deðiþkenleri yazalým.
//(Burda size býrakýyorum scriptleri nasýl oluþturacaðýnýzý vs)

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

            Debug.Log($"{name} isimli oyuncunun {can} adet caný var ve statusü {status} 'dur.");

            _enemy = enemyGameObject.GetComponent<Enemy>();

            _enemy.EnemyPlayer( 15, "Victor");

            Debug.Log($"{_enemy.name} isimli oyuncunun {_enemy.can} adet caný var ve statusü {status} 'dur.");

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
