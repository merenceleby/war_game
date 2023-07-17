using UnityEngine;
using TMPro;
public class CubeScore : MonoBehaviour
{
    public TextMeshProUGUI ScoreCube;
    private static int losescore;

    void Start()
    {
        losescore = 0;
        ScoreCube.text = "Cube Detect: " + losescore;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            loseScore();
        }
    }
    public void loseScore()
    {
        losescore++;
        ScoreCube.text = "Cube Detect: " + losescore;
    }
}
