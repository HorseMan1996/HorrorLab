using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerRaycast : MonoBehaviour
    {
        public float rayDistance = 10f; // Maksimum mesafe
        public LayerMask hitLayers;     // Hangi katmanlarý tespit edeceðini seçebilirsin (isteðe baðlý)

        void Start()
        {

        }

        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Ekrandaki fare konumundan ray çýkar
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayDistance, hitLayers))
            {
                if (hit.collider.CompareTag("CollectableObject"))
                {
                    Debug.Log("Hit object: " + hit.collider.name);
                }
                // Örnek: Temas edilen objeye renk ver
                //hit.collider.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("No object hit.");
            }
        }
    }
}
