using ObjectPooling;
using UnityEngine;

namespace Cubes
{
    public class CubePool : ObjectPool<Cube>
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
                Dequeue();
        }

        protected override void DequeueSettings(Cube pooledObject)
        {
            pooledObject
                .SetTransformParent(null)
                .SetActive(true)
                .SetRigidbodyVelocity(Vector3.one * Random.Range(-2f, 2f))
                .PoolParent = this;
        }

        protected override void EnqueueSettings(Cube pooledObject)
        {
            pooledObject
                .SetTransformParent(transform)
                .SetLocalPosition(Vector3.zero)
                .SetActive(false)
                .SetRigidbodyVelocity(Vector3.zero)
                .PoolParent = null;
        }
    }
}
