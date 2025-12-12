using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour{


    private const string ISRUNNING = "IsRunning";


    [SerializeField] private Player player;
    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void LateUpdate() {
        animator.SetBool(ISRUNNING, player.IsWalking());
    }
}
