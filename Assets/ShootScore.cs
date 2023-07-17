using UnityEngine;
using TMPro;

public class ShootScore : MonoBehaviour
{
    public TextMeshProUGUI Score;
    private static int shooted;

    void Start()
    {
        shooted = 0;
        Score.text = "Shoot Score: " + shooted;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            ShootedScores();            
        }
    }
    private void ShootedScores()
    {
        shooted++;
        Score.text = "Shoot Score: " + shooted;
    } 
}
