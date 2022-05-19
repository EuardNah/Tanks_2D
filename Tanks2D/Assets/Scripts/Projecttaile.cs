using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecttaile : MonoBehaviour
{
    [SerializeField] private int _damage = 5;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private string _myTag = "";

    private void OnTriggerEnter2D(Collider2D collision) 
    {
       if(collision.gameObject.GetComponent<Tanks>() !=null && collision.gameObject.tag != _myTag) 
       {
           collision.gameObject.GetComponent<Tanks>().TakeDamage(_damage);
           gameObject.SetActive(false);
       }
    }

    IEnumerator  DeleteProjecttaile()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);

    }
    void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
        StartCoroutine(DeleteProjecttaile());
    }
}
