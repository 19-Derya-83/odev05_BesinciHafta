using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soru5 - 2 ayrý objemiz ve her ikisine attýðýmýz 2 ayrý scriptimiz olsun. Bu iki scripte int, string ve bool deðiþkenler ve bu deðiþkenlerle alakalý metot oluþturalým. En son bu objelerden birbirine ve birbirinin içindeki scriptlere ulaþýp deðiþkenlerin deðerlerini deðiþtirelim. Ve metotlarýný kullanýp consola deðiþtirdiðimiz deðiþkenleri yazalým.
//(Burda size býrakýyorum scriptleri nasýl oluþturacaðýnýzý vs)

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
            Debug.Log($"{name} isimli oyuncunun {can} adet caný var ve statusü {status} 'dur.");

            _hero = heroGameObject.GetComponent<Hero>();

            _hero.HeroPlayer(8, "Angel");

            Debug.Log($"{_hero.name} isimli oyuncunun {_hero.can} adet caný var ve statusü {status} 'dur.");

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
