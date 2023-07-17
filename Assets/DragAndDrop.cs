using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 distance;
    public CubeScore cubeScore;
    private void OnMouseDown()
    {
        distance = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        cubeScore.loseScore();
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - distance);   
    }

}
