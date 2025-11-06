using UnityEngine;

public class ChaseState : AIState
{
    public ChaseState(AIController controller) : base(controller) { }
<<<<<<< HEAD
    public override void OnEnter() { }
    public override void UpdateState() { }
    public override void OnExit() { }
}
=======

    public override void OnEnter()
    {
        Debug.Log("Entrando en estado de Persecución.");
        m_agent.speed = m_controller.chaseSpeed;
    }

    public override void UpdateState()
    {
        // 1. Condición de transición: ¿hemos perdido al jugador?
        if (Vector3.Distance(m_controller.transform.position, m_playerTransform.position) > m_controller.loseSightRadius)
        {
            m_controller.ChangeState(new PatrolState(m_controller));
            return;
        }

        // 2. Lógica del estado: perseguir al jugador.
        m_agent.destination = m_playerTransform.position;
    }

    public override void OnExit() { }
}
>>>>>>> aed9e1a1b150b1eacffd413ff564bc5fbda013d6
