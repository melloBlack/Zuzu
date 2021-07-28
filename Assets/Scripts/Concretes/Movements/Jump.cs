using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zuzu.Concretes.Movements
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] float jumpForce=250;
        public void JumpAction(Rigidbody2D _rigidbody2D)
        {
            _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
    }
}

