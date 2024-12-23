using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    //Shooter以外に触れたら削除する
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<ShooterBehaviour>(out var shooterBehaviour))
        {
            //何もしない
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
