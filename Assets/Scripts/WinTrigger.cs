using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public GameObject youWinText;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        youWinText.SetActive(false);

    }

    // void onTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.tag == "Bullet")
    //     {
    //         youWinText.SetActive(true);
    //     }
    // }
    private void OnCollisionEnter(Collision other)
    {
        //GetComponent<MeshRenderer>().material.color = Color.red;

        youWinText.SetActive(true);
        StartCoroutine(Countdown());

    }
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(1);
    }

}
