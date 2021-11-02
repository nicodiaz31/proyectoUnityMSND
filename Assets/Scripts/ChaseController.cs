using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseController : LookAtPlayerController
{

    public enum EnemyType
    {
        JustLook,
        ChaseAndLook,
        SwitchType
    }

    [SerializeField] private EnemyType enemytype;

    void Start()
    {
        SetEnemyType(enemytype);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        LookAt();
        Vector3 direction = (player.transform.position - transform.position).normalized;
        transform.position += 10 * direction * Time.deltaTime;
    }

    private void SetEnemyType(EnemyType enemyType)
    {
        switch(enemyType)
        {
            case EnemyType.JustLook:
                LookAt();
                break;
            case EnemyType.ChaseAndLook:
                LateUpdate();
                break;

        }
    }
}