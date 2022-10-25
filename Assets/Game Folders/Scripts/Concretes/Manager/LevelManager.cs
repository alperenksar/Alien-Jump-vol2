using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienJump.Manager
{
    public class LevelManager : MonoBehaviour
    {
        
         [SerializeField]    private GameObject[] platformPrefabs;
         [SerializeField]    private int CountOfPrefabs;
         [SerializeField]    private float levelWidth;
         [SerializeField]    private float MinY, MaxY;
         [SerializeField]    private Vector3 SpawnPosition;

        private void Start()
        {
            for (int i = 0; i < CountOfPrefabs; i++)
            {
                int a = 0;
                // type1 beyaz 0
                // type2 k�rm�z� ye�il b�y�k 1
                //type3 te�il 2
                //type4 k�rm�z� ye�il k���k 3


                int index = Random.Range(0,100);
                if (index <= 15)
                {
                    a = 1;
                }
                else if(index>15 && index<=45)
                {
                    a = 2;
                }
                else if (index > 45 && index <= 60)
                {
                    a = 3;
                }
                else
                {
                    a = 0;
                }

                SpawnPosition.y += Random.Range(MinY, MaxY);
                SpawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(platformPrefabs[a], SpawnPosition, Quaternion.identity);
               
            }
        }


      
    }

}
