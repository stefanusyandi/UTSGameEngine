using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculAmmo : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;

    public GameObject[] obyekAmmo;

    void Start()
    {
        // Bisa tambahkan inisialisasi jika diperlukan
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > jeda)
        {
            int random = Random.Range(0, obyekAmmo.Length);
            Instantiate(obyekAmmo[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
