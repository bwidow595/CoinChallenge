using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static Coins;
using static EnemyStats;
using static UnityEngine.Rendering.DebugUI;

public class PlayerController : MonoBehaviour
{
    private Vector2 input;

    [SerializeField]
    private float coeffMove = 5f;

    [SerializeField]
    private float coeffRotate = 100f;

    private float y;

    [SerializeField]
    private Transform playerTransform;

    [SerializeField]
    private float rayDistance;

    // calques liées physics
    [SerializeField]
    private LayerMask layers;

    Rigidbody rb;
    private Animator animator;

    [SerializeField]
    private bool isGrounded;

    public static bool isJumping;

    public static float extraGravity;

    [SerializeField] private float jumpPower;

    private Vector3 velocity;

    private EnemyStats enemySts;
    public GameObject pickupEffectKill;

    public GameObject pickupEffectCoin;

    private AudioSource audioSource;
    [SerializeField] private AudioClip coinCollect;

    private CharacterStats characterStats;
    private Timer timer;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        enemySts = GetComponent<EnemyStats>();
        audioSource = GetComponent<AudioSource>();
        characterStats = GetComponent<CharacterStats>();
        timer = GetComponent<Timer>();
    }

    private void Update()
    {
        GetInput();
        Rotate();
        if (Grounded() && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void LateUpdate()
    {
        if (isJumping = true && Grounded() == true)
        {
            isJumping = false;
            extraGravity =0f;
            animator.SetBool("Jump", false);

        }
    }
    // appeller par intervalle régulier 'conseillé physique du jeu
    private void FixedUpdate()
    {
        Mouvement();
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            audioSource.PlayOneShot(coinCollect);
            Coins item = col.gameObject.GetComponent<Coins>();
            int scoreWin = item.GetScoreBonus();
            CoinsType coinType = item.GetCoinsType();
            Debug.Log("collision du player avec un coin de type " + coinType + " de valeur " + scoreWin);
            GameController.IncScoreCoins(scoreWin);
            GameController.NbrTypeCoins(coinType);
            Instantiate(pickupEffectCoin, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("EnemyHead"))
        {
            EnemyStats kill = coll.gameObject.GetComponent<EnemyStats>();
            EnemyType enemyType = kill.GetEnemyType();
            Debug.Log("colision du player avec un enemy de type " + enemyType);
            Debug.LogError("Enemy Dead Head");
            GameController.NbrTypeEnemy(enemyType);
            Instantiate(pickupEffectKill, transform.position, Quaternion.identity);
            Destroy(coll.transform.parent.gameObject);
        }

        if (coll.gameObject.CompareTag("Life"))
        {
            characterStats.IncreaseLife(10);
            Debug.Log("ajout de vie ");
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.CompareTag("Time+"))
        {
            timer.IncreaseTime(1f);
            Debug.Log("ajout de temps");
            Destroy(coll.gameObject);
        }
    }

    private void GetInput()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        animator.SetFloat("Speed", input.y);
    }
    private void Mouvement()
    {
        Vector3 movement = new Vector3(0, rb.velocity.y + extraGravity, input.y * coeffMove);
        rb.velocity = transform.TransformDirection(movement);
    }
    private void Rotate()
    {
         y = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * y * coeffRotate * Time.deltaTime);
    }
    private void Jump()
    {
        animator.SetBool("Jump", true);
        extraGravity = 0;
        rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);
    }
    private bool Grounded()
    {
        RaycastHit hit;
        Vector3 origin = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
        Debug.DrawRay(origin, transform.TransformDirection(Vector3.down) * rayDistance, Color.red);
        isGrounded = Physics.Raycast(origin, transform.TransformDirection(Vector3.down), out hit, rayDistance, layers);
        animator.SetBool("Grounded", isGrounded);
        return isGrounded;
    }
}