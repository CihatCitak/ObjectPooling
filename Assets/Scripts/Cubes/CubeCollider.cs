using UnityEngine;

namespace Cubes
{
    public class CubeCollider : MonoBehaviour
    {
        [SerializeField] Cube cube;

        private void OnCollisionEnter(Collision collision)
        {
            cube.PoolParent?.Enqueue(cube);
        }
    }
}