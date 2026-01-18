using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target Settings")]
    public Transform target; // Այստեղ պետք է քաշել Player-ին
    public float smoothSpeed = 0.125f; // Ինչքան փոքր է թիվը, այնքան ավելի սահուն է հետևում
    public Vector3 offset = new Vector3(0, 2, -10); // Կամերայի հեռավորությունը խաղացողից

    void LateUpdate()
    {
        if (target != null)
        {
            // Հաշվարկում ենք այն դիրքը, որտեղ կամերան պետք է լինի
            Vector3 desiredPosition = target.position + offset;
            
            // Սահուն անցում ներկա դիրքից դեպի ցանկալի դիրքը
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            
            // Փոխում ենք կամերայի դիրքը
            transform.position = smoothedPosition;
        }
    }
}