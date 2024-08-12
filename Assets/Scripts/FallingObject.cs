using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public RandomSpawn randomSpawn;
    public int myScore = 10;

    private void OnCollisionEnter(Collision collision)
    {
        randomSpawn.totalScore -= myScore;
    }

    private void OnTriggerEnter(Collider other)
    {
        randomSpawn.totalScore += myScore;
    }
}
