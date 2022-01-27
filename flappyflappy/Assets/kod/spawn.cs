
using UnityEngine;

public class spawn : MonoBehaviour
{
   public GameObject prefab;
   public float spawnRate = 1f;
   public float minHeight = -1f;
   public float maxHeight = 1f;

   private void OnEnable()
   {
       InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);

   }

   private void OnDisable() {
       
       CancelInvoke(nameof(Spawn));
   }

   private void Spawn() {

       GameObject borular = Instantiate(prefab, transform.position, Quaternion.identity );
       borular.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
   }
}
