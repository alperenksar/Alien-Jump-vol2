using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AlienJump.UI;


namespace AlienJump.Manager
{
    public class LevelManager : MonoBehaviour
    {
         [SerializeField]    private GameObject[] platformPrefabs;
         [SerializeField]    private int CountOfPrefabs;
         [SerializeField]    private float levelWidth;
         [SerializeField]    private float MinY, MaxY;
         [SerializeField]    private Vector3 SpawnPosition;

        private int indexNumber;

        [Header("Should be equal for CountOfPrefabs")]
        public int _counterOfCycle ;

        private void Start()
        {
            for (int i = 0; i < CountOfPrefabs; i++)
            {

                ReturnIndex();
                SpawnPosition.y += Random.Range(MinY, MaxY);
                SpawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(platformPrefabs[indexNumber], SpawnPosition, Quaternion.identity);
            }
        }


        private void LateUpdate()
        {
            Debug.Log(_counterOfCycle);



            if (_counterOfCycle <= 15)
            {
                for (int i = 0; i < CountOfPrefabs; i++)
                {

                    ReturnIndex();
                    SpawnPosition.y += Random.Range(MinY, MaxY);
                    SpawnPosition.x = Random.Range(-levelWidth, levelWidth);
                    Instantiate(platformPrefabs[indexNumber], SpawnPosition, Quaternion.identity);
                }

                _counterOfCycle = CountOfPrefabs;
            }
        }



        int ReturnIndex()
        {
            indexNumber = 0;

            int index = Random.Range(0, 100);


            if (index <= 10)
            {
                indexNumber = 1;
            }
            else if (index > 10 && index <= 20)
            {
                indexNumber = 2;
            }
            else if (index > 20 && index <= 30)
            {
                indexNumber = 3;
            }
            else
            {
                indexNumber = 0;
            }

            return indexNumber;
        }


      
    }

}
