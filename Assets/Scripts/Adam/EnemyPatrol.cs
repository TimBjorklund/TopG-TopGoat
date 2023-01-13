using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header("Patrol Points")]
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;

    [Header("Enemy")]
    [SerializeField] private Transform enemy;

    [Header("Movement parameters")]
    [SerializeField] private float speed;
    private Vector3 initScale;
    private bool movingLeft;
    private void Awake()
    {
        initScale = enemy.localScale;
    }

    private void Update()
    {
        if (movingLeft)
        {
            if (enemy.position.x >= leftEdge.position.x)
                MoveInDirection(-1); //När fienden går mot riktningen -1 så går den vänster - Adam
            else
            {
                DirectionChange(); //Byter riktningen - Adam
            }
        }
        else
        {
            if (enemy.position.x <= rightEdge.position.x)
                MoveInDirection(1); //När fienden går mot riktningen 1 så går den vänster - Adam
            else
                DirectionChange(); //Byter riktningen - Adam
            
        }
    }

    private void DirectionChange()
    {
        movingLeft = !movingLeft;
    }
    private void  MoveInDirection(int _direction) //Får fienden att röra sig åt den riktningen - Adam

    {
        //Får fienden att kolla åt riktningen - Adam
        enemy.localScale = new Vector3(Mathf.Abs(initScale.x) * _direction,
            initScale.y, initScale.z);

        //Får fienden att röra sig åt den riktningen - Adam
        enemy.position = new Vector3(enemy.position.x + Time.deltaTime * _direction * speed, enemy.position.y, enemy.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
