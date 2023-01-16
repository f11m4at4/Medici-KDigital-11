using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ³ª¶û ºÎµúÈ÷´Â ³à¼®Àº ´Ù Á×¿©¹ö¸®°Ú´Ù!!!
public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
