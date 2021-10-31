using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceController : MonoBehaviour
{
    public Transform enemyTarget;

    private GameObject[] enemies; 
    [SerializeField] private float fireRange = 15.0f;

    [SerializeField] float fireWait = 5f;

    [SerializeField] Transform defenceTop;

    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform projectilePoint;

    private ProjectileMovement projectileMovement;

    private bool canFireProjectile = true;


    [SerializeField] private float damage = 100;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FindEnemyTarget());
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyTarget == null)
        {
            return;
        }

        RotateDefenceTop();
    }

    IEnumerator FindEnemyTarget()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
      
        float shortestDistance = Mathf.Infinity;
        GameObject closestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                closestEnemy = enemy;
            }
        }

        if (closestEnemy != null && shortestDistance <= fireRange)
        {
            enemyTarget = closestEnemy.transform;

            if (canFireProjectile)
            {
                StartCoroutine(DefenceFire());
            }
        }
        else
        {
            enemyTarget = null;
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(FindEnemyTarget());
    }

    IEnumerator DefenceFire()
    {
        canFireProjectile = false;
        GameObject proj = Instantiate(projectilePrefab, projectilePoint.position, defenceTop.rotation);
        proj.GetComponent<ProjectileMovement>().SetDamage(damage);
        yield return new WaitForSeconds(fireWait);
        canFireProjectile = true;
    }

    void RotateDefenceTop()
    {
            Vector3 direction = enemyTarget.position - transform.position;
            float turnAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            defenceTop.rotation = Quaternion.AngleAxis(turnAngle - 90.0f, Vector3.forward);   
    }
}
