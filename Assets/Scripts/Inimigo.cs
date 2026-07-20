using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public Transform castelo;
    public float velocidade = 2f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            castelo.position,
            velocidade * Time.deltaTime
        );
    }
}
