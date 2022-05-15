using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTarget : MonoBehaviour,IDamageable {
	public float hp = 100f;
	public Animator animator;

	private void Awake() {
		animator = GetComponent<Animator>();
	}

	private void Update() {
		if(animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Die")
		&& animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f){
			Destroy(gameObject);
		}
	}

	public void OnDamage(float damage)
	{
		hp -= damage;

		if(hp <= 0)
		{
			animator.SetTrigger("Die");
		}
	}
}
