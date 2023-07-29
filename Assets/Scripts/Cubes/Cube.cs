using UnityEngine;

namespace Cubes
{
    public class Cube : MonoBehaviour
    {
        [SerializeField] Rigidbody rb;

        private CubePool poolParent;
        public CubePool PoolParent { get => poolParent; set => poolParent = value; }

        public Cube SetActive(bool value)
        {
            gameObject.SetActive(value);

            return this;
        }

        public Cube SetTransformParent(Transform parent)
        {
            transform.SetParent(parent);

            return this;
        }

        public Cube SetLocalPosition(Vector3 localPos)
        {
            transform.localPosition = localPos;

            return this;
        }

        public Cube SetRigidbodyVelocity(Vector3 velocity)
        {
            rb.velocity = velocity;

            return this;
        }
    }
}
