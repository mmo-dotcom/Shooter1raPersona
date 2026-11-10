using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public int playerHealth = 3;
    public int damage = 1;
    private NavMeshAgent agent;
    public GameObject panelLose;
    void Start()
    {
        panelLose.SetActive(false);
    }

    void Update()
    {
        
    }
    public void playerDamaged(int damaged)
    {
        playerHealth -= damage;

        if (playerHealth <= 0)
        {
            panelLose.gameObject.SetActive(true);
        }
    }

}
