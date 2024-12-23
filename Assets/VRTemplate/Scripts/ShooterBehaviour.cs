using UnityEngine;

public class ShooterBehaviour : MonoBehaviour
{
    //弾のPrefab
    [SerializeField] private GameObject bulletPrefab;
    
    //弾の発射速度
    [SerializeField] private float shootSpeed = 1000f;
    
    //トリガーを押されたら弾を発射する
    public void Shoot()
    {
        Debug.Log("Shoot");
        
        //弾のインスタンスを生成
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        
        //弾を前方に発射する
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootSpeed);
    }
}
