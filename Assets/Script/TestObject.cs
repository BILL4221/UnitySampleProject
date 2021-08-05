using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runnex.TestProject
{
    public class TestObject : MonoBehaviour
    {
        [SerializeField]
        private float angularSpeed;
        [SerializeField]
        private float radius;
        private float currentAngle;

        private void Awake()
        {
            currentAngle = 0;
        }
        private void Update()
        {
            currentAngle += angularSpeed;
            float x = Mathf.Cos(currentAngle) * radius;
            float y = Mathf.Sin(currentAngle) * radius;
            transform.position = new Vector3(x, y, 0);
        }
    }
}
