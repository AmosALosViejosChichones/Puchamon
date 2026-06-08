using UnityEngine;

public class movimientodeljugador : MonoBehaviour
{
   [Header("Movimiento Horizontal")]
   [SerializeField] private Rigidbody2D rb2D;
   [SerializeField] private float velocidadMovimiento;
   [SerializeField] private float entradaHorizontal;

    [Header("salto")]
    [SerializeField] private float fuerzaSalto;

    private bool entradaSalto;
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        rb2D.linearVelocity = new Vector2(entradaHorizontal * velocidadMovimiento, rb2D.linearVelocity . y);
    }
}
