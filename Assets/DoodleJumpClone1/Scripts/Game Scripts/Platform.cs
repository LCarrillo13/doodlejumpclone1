using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InGame
{
    public class Platform : MonoBehaviour
    {
        private DJPlayer player;
        public void MoveDown(float _amount)
        {
            transform.position -= transform.up * _amount;
        }

        // OnCollisionEnter2D is called when this collider2D/rigidbody2D has begun touching another rigidbody2D/collider2D (2D physics only)
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (player.IsJumping && player.platform != this)
            {
                //Tell manager to move down
                PlatformManager manager = FindObjectOfType<PlatformManager>();
                manager.MovePlatformDown();
            }
        }
    }
}
