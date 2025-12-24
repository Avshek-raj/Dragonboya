using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    private Animator anim;
    private PlayerMovement PlayerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake() {
        anim = GetComponent<Animator>();
        PlayerMovement = GetComponent<PlayerMovement>();
    }

    private void Update() {
        if (Input.GetMouseButton(0) &&  cooldownTimer > attackCooldown) {
            Attack();
        }
        cooldownTimer += Time.deltaTime;
    }

    private void Attack() {
        anim.SetTrigger("attack");
        cooldownTimer = 0;
        
    }

    // private void canAttack() {
    //     return 
    // }
}
