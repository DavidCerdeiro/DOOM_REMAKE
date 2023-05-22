using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FormerHuman : MonoBehaviour
{
    public float viewRadius;
    public float viewAngle;
    public float range;

    public LayerMask targetPlayer;
    public LayerMask obstacleMask;

    public GameObject player;

    public float vida;
    public bool muerto = false;

    public AudioSource dañoSXF;
    public AudioSource disparoSFX;
    public AudioSource detectadoSFX;

    private float tiempoGrito;
 
    bool detected = false;

    private bool disparando = false;


    UnityEngine.AI.NavMeshAgent pathfinder;

    Animator animator;

    public float timeBetweenAttacks;
    private float tiempoDisparo = 1f;
    bool alreadyAttacked = false; 
    public GameObject bala;
    public GameObject pistola;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        pathfinder = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (muerto || disparando)
        {
            pathfinder.SetDestination(this.transform.position);
        }
        else
        {
            if (detectado() && !enRango())
                perseguir();
            else if (detectado() && enRango())
                if (!alreadyAttacked)
                    atacar();
                else 
                    Invoke(nameof(esquivar),tiempoDisparo);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("bala"))
        {
            dañoSXF.Play();
            --vida;
            Debug.Log("Tocado");
            if (!detectado())
            {
                transform.LookAt(player.transform.position);
            }
            if (vida <= 0)
            {
                muerto = true;
                animator.SetBool("Muerto",true);
                pathfinder.isStopped = true;
                Invoke(nameof(Destruir), 2.0f);
            }
        }
        if (other.CompareTag("Fire"))
        {
            dañoSXF.Play();
            vida = 0;
            Debug.Log("Tocado");
            if (!detectado())
            {
                transform.LookAt(player.transform.position);
            }
            if (vida <= 0)
            {
                muerto = true;
                animator.SetBool("Muerto", true);
                pathfinder.isStopped = true;
                Invoke(nameof(Destruir), 2.0f);
            }
        }
    }  

    private void Destruir() 
    {
        Destroy(gameObject);
    } 

    private bool detectado()
    {
        Vector3 playerTarget = (player.transform.position - transform.position).normalized;

        if (Vector3.Angle(transform.forward, playerTarget) < viewAngle / 2)
        {
            float distanceToTarget = Vector3.Distance(transform.position, player.transform.position);
            if (distanceToTarget <= viewRadius)
            {
                if (Physics.Raycast(transform.position, playerTarget, distanceToTarget, obstacleMask) == false)
                {
                    //Debug.Log("Look at me Hector");
                    if(!detected) 
                        detectadoSFX.Play();
                    detected = true;

                }
                else 
                    detected = false;
            }
            else 
                detected = false;
        }
        else 
            detected = false;
        return detected;
    }

    private void perseguir() 
    {
        pathfinder.SetDestination(player.transform.position);
        animator.SetBool("Run",true);   
        transform.LookAt(player.transform.position);     
    }

    private bool enRango()
    {
        float distance = Vector3.Distance(player.transform.position,this.transform.position);
        Vector3 playerTarget = (player.transform.position - transform.position).normalized;

        return distance < range /*&& Physics.Raycast(transform.position, playerTarget, distance, obstacleMask) == false*/ ;
    }

    private void atacar()
    {
        if (!alreadyAttacked)
        {
            disparando = true;
            animator.SetBool("Run",false);
            animator.SetBool("Disparo", true);
            transform.LookAt(player.transform.position);
            alreadyAttacked = true;
            Invoke(nameof(terminardisparo), 0.24f);
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    public void disparoAnimationEvent()
    {
        StartCoroutine("disparo");
    }

    public void disparo()
    {
        disparoSFX.Play();
        Instantiate(bala, pistola.transform.position, transform.rotation);
    }

    private void terminardisparo()
    {
        disparando = false;
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void esquivar()
    {
        Vector3 point;

        if (RandomPoint(player.transform.position, range, out point)) //pass in our centre point and radius of area
        {
            animator.SetBool("Run", true);
            animator.SetBool("Disparo",false);
            transform.LookAt(player.transform.position);
            pathfinder.SetDestination(point);
        }
    }

    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {

        Vector3 randomPoint = center + Random.insideUnitSphere * (range - 3f); //random point in a sphere 
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas)) 
        {
            result = hit.position;
            return true;
        }

        result = Vector3.zero;
        return false;
    }

}
