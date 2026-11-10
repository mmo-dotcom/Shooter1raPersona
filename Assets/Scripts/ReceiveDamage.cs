using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ReceiveDamage : MonoBehaviour
{
    public int enemyHealth = 100;
    public TextMeshProUGUI enemyHealthText;
    public Image healthBar;
    private NavMeshAgent agent;
    private CapsuleCollider capsuleCollider;
    public int health = 3;
    public float atkPerSec = 1f;
    private float nextAtk = 0f;
    public Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
            {
                player = playerObj.transform;
            }
        }
    }

    void Update()
    {
        if (player != null && health > 0)
        {
            agent.SetDestination(player.position);

            float distance = Vector3.Distance(transform.position, player.position);
            float atkRange = agent.stoppingDistance + 0.5f;

            if (distance <= atkRange && Time.time >= nextAtk)
            {
                nextAtk = Time.time + 1f / atkPerSec;
                
                Player Player = player.GetComponent<Player>();
                if (Player != null)
                {
                    Player.playerDamaged(1);
                }
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            enemyHealth -= 10;
            enemyHealthText.text = enemyHealth.ToString();
            healthBar.fillAmount = enemyHealth / 100f;

            if(enemyHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
