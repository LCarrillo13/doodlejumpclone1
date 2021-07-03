using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InGame
{
    public class PlatformManager : MonoBehaviour
    {

        [SerializeField]
        private DJPlayer player;
        private List<Platform> platforms = new List<Platform>();

        public void MovePlatformDown()
        {
            foreach (Platform platform in platforms)
            {
                platform.MoveDown(5);
            }

        }

        public void NewPlatform()
        {
            //replace gameobject with the prefab randomization
            GameObject newObj = Instantiate(gameObject);
            platforms.Add(newObj.GetComponent<Platform>());
        }
    }
}
