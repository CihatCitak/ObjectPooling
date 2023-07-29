using ObjectPooling;
using UnityEngine;

namespace Cubes
{
    public class Cube : MonoBehaviour
    {
        [SerializeField] Rigidbody rb;

        public IObjectPool<Cube> PoolParent { get; set; }

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
