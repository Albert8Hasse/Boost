using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTest : MonoBehaviour
{

    private float timerOne = 0f;

    private float timeOne =0f;

    private float timerWave = 0f;

    private float timeWave = 5f;

    private int countPerWave = 3;

    public GameObject spawnPerfab;

    // Update is called once per frame

    void Update()
    {

        timerWave += Time.deltaTime;

        if (timerWave < timeWave && countPerWave != 5)
        {

            timerOne += Time.deltaTime;

            if (timerOne > timeOne)
            {


                Instantiate(spawnPerfab, new Vector3(100f, 10f, -7f

                    ),

                    spawnPerfab.transform.rotation);

                Instantiate(spawnPerfab, new Vector3(100f, Random.Range(7f, 45f),-7

                    ),

                    spawnPerfab.transform.rotation);

                countPerWave++;

                timerOne -= timeOne;

            }

        }

        if (timerWave >= timeWave)
        {

            timerWave -= timeWave;

            countPerWave = 0;

        }

    }

}