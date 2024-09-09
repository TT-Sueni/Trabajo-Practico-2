
using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    [SerializeField] private float bounce = 1.05f;
    [SerializeField] LayerMask playerMask;
    [SerializeField] public LayerMask leftGoalMask;
    [SerializeField] public LayerMask rightGoalMask;
     
    [SerializeField] private TMP_Text leftscorePoints;
    [SerializeField] private TMP_Text rightscorePoints;
    private int leftScore = 0;
    private int rightScore = 0;


    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (CheckLayerInMask(playerMask, other.gameObject.layer))
        {
            Debug.Log("toco jugador");
            Vector2 direction = rigidbody2d.velocity.normalized;

            rigidbody2d.AddForce(direction * bounce, ForceMode2D.Impulse);
        }
        else if (CheckLayerInMask(leftGoalMask, other.gameObject.layer))
        {

            SetTransformX();


            rigidbody2d.velocity = Vector2.zero;
            rightScore++;
            rightscorePoints.text = rightScore.ToString();

        }
        else if (CheckLayerInMask(rightGoalMask, other.gameObject.layer))
        {

            SetTransformX();


            rigidbody2d.velocity = Vector2.zero;
            leftScore++;
            leftscorePoints.text = leftScore.ToString();

        }

    }
    void SetTransformX()
    {
        transform.position = new Vector2(0, 0);
    }

    public static bool CheckLayerInMask(LayerMask mask, int layer)
    {
        return mask == (mask | (1 << layer));
    }


}
