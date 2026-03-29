using System;
using System.Collections;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    private Coroutine _winCoroutine;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
            _winCoroutine = StartCoroutine(WinRoutine());
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item") && _winCoroutine != null)
            StopCoroutine(_winCoroutine);
    }

    private IEnumerator WinRoutine()
    {
        yield return new WaitForSeconds(0.6f);
        if (GameManager.Instance.CurrentState != GameManager.GameState.Playing) yield break;
        GameManager.Instance.ChangeState(GameManager.GameState.Win);
    }

}
