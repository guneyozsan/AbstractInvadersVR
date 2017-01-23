using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{

    public GameObject targetPrefab;
    public GameObject targetRhythmPrefab; 
    public GameObject targetStartPoint;
    public GameObject targetParent;
    public Material targetReachedMaterial;

    float forceApplied = -700;
    float lifeTime = 12;
    float lifeTimeSafety = 2f;
    float spawnRangeX = 18;
    float spawnRangeY = 9;

    bool switcher = true;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("GenerateTarget", 0f, 1f/2f);
        InvokeRepeating("GenerateTargetRhythm", 0f, 2f);
        InvokeRepeating("IncreaseDifficulty", 0f, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform target in targetParent.transform)
        {
            if (target.transform.position.z < -0.1f && target.GetComponent<MeshRenderer>().material.color.a == 1)
            {
                target.GetComponent<MeshRenderer>().material = targetReachedMaterial;
            }
        }
    }

    void GenerateTarget()
    {
        targetStartPoint.transform.position = new Vector3(spawnRangeX * Random.Range(0f, 1f) - spawnRangeX / 2, spawnRangeY * Random.Range(0f, 1f) - spawnRangeY / 2, targetStartPoint.transform.position.z);
        GameObject wavePiece = Instantiate(targetPrefab, targetStartPoint.transform.position, targetStartPoint.transform.rotation) as GameObject;
        wavePiece.transform.parent = targetParent.transform;
        wavePiece.GetComponent<Rigidbody>().AddForce(transform.forward * -500 * wavePiece.GetComponent<Rigidbody>().mass);

        StartCoroutine(DelayedScaleOverTime(lifeTime, 1f, wavePiece));
        Destroy(wavePiece, lifeTime + lifeTimeSafety);
    }

    void GenerateTargetRhythm()
    {
        if (switcher)
        {
            targetStartPoint.transform.position = new Vector3(- spawnRangeX / 2, targetStartPoint.transform.position.y, targetStartPoint.transform.position.z);
            switcher = !switcher;
        } else
        {
            targetStartPoint.transform.position = new Vector3(spawnRangeX / 2, targetStartPoint.transform.position.y, targetStartPoint.transform.position.z);
            switcher = !switcher;
        }
        GameObject wavePiece = Instantiate(targetRhythmPrefab, targetStartPoint.transform.position, targetStartPoint.transform.rotation) as GameObject;
        wavePiece.transform.parent = targetParent.transform;
        wavePiece.GetComponent<Rigidbody>().AddForce(transform.forward * forceApplied * wavePiece.GetComponent<Rigidbody>().mass);

        StartCoroutine(DelayedScaleOverTime(lifeTime, 1f, wavePiece));
        Destroy(wavePiece, lifeTime + lifeTimeSafety);
    }

    IEnumerator DelayedScaleOverTime (float lifeTime, float time, GameObject targetScaled)
    {
        yield return new WaitForSeconds(lifeTime);
        StartCoroutine(ScaleOverTime(time, targetScaled));
    }

    IEnumerator ScaleOverTime(float time, GameObject targetScaled)
    {
        float currentTime = 0.0f;
        Color targetColor = targetScaled.GetComponent<MeshRenderer>().material.color;

        do
        {
            float alpha = Mathf.Lerp(1f, -0.1f, currentTime / time);
            targetScaled.GetComponent<MeshRenderer>().material.color = new Color(targetColor.r, targetColor.g, targetColor.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);
        
    }

    void IncreaseDifficulty()
    {
        forceApplied--;
    }
}