using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InGame
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class DJPlayer : MonoBehaviour
    {

        public bool IsJumping = false;
        public Platform platform;
        private Rigidbody2D playerRB;
        public float jumpHeight = 10;


        private void Start()
        {
            playerRB = GetComponent<Rigidbody2D>();
        }

    }
}
