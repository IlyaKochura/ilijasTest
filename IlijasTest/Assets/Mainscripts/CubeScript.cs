using UnityEngine;


namespace Mainscripts
{
    public class CubeScript : MonoBehaviour
    {
        public float speed;

        void Update()
        {
            Vector3 direction = new Vector3(0, -1 * speed * Time.deltaTime);
            transform.Translate(direction);
        }
    }
}