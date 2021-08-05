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
        private float length;
        private float currentAngle;

        private void Awake()
        {
            currentAngle = 0;
        }
        private void Update()
        {
            currentAngle += angularSpeed;
            float x = Mathf.Cos(currentAngle) * length;
            transform.position = new Vector3(x, 0, 0);
        }
    }
}
