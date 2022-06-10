using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

namespace Maze
{
    public class BadBonus : Bonus, IFly, IRotation
    {
        private float heightFly;
        private float speedRotation;

        public event Action<string, Color> OnCaughtPlayer = delegate (string str, Color color) { };


        public void Awake()
        {
            
            heightFly = Random.Range(1f, 1.5f);
            speedRotation = Random.Range(13f, 40f);
            _transform = GetComponent<Transform>();
        }

        public void Fly()
        {
            _transform.position = new Vector3(_transform.position.x, Mathf.PingPong(Time.time, heightFly), _transform.position.z);
        }

        public void Rotate()
        {
            _transform.Rotate(Vector3.up * (Time.deltaTime * speedRotation), Space.World);
        }

        public override void Update()
        {
           Fly();
           Rotate();
        }
        protected override void Interaction()
        {
            OnCaughtPlayer.Invoke(gameObject.name, _color);
        }
    }
}
