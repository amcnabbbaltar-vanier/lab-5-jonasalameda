using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void GoHit()
    {
        animator.SetTrigger("GoHit");

        // Notify GameManager
        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(1); // Add 1 point per hit
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
