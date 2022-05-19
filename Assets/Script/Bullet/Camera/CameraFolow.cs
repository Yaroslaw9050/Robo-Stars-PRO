using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFolow : MonoBehaviour
{
    [SerializeField] private GameObject mainCharacter;
    [SerializeField] private float returnSpeed;
    [SerializeField] private float height;
    [SerializeField] private float rearDistance;
    private Vector3 cameraOffset;
    private Vector3 currentVector;
    void Start()
    {
        transform.position = new Vector3(mainCharacter.transform.position.x, mainCharacter.transform.position.y + height, mainCharacter.transform.position.z - rearDistance);
        transform.rotation = Quaternion.LookRotation(mainCharacter.transform.position - transform.position);
    }
    void Update()
    {
        CameraMove();
    }
    private void CameraMove()
    {
        currentVector = new Vector3(mainCharacter.transform.position.x + cameraOffset.x, mainCharacter.transform.position.y + height, (mainCharacter.transform.position.z - rearDistance) + cameraOffset.z);
        transform.position = Vector3.Lerp(transform.position, currentVector, returnSpeed * Time.deltaTime);
    }
    public void SetOffset(Vector3 offset)
    {
        if(offset.z < 0)
        cameraOffset = offset * 10; // під час руху "вниз" по карті, камера відступатиме сильніше ніж..
        else if(offset.z > 0)
        cameraOffset = offset * 3; // при русі "вгору"
        else
        cameraOffset = offset * 8; // відступ при русі ліворуч та праворуч 
    }
}
