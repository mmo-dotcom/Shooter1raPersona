using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReceiveDamage : MonoBehaviour
{
    public int enemyHealth = 100;
    public TextMeshProUGUI enemyHealthText;

    public Image healthBar;

    void Start()
    {
        
    }


    void Update()
    {
        
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
