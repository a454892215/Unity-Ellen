using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    RectTransform indexTrans;
    void Start()
    {
        indexTrans = transform.Find("Index").GetComponent<RectTransform>();
        indexTrans.DORotate(new Vector3(0, 0, -180), 1).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        indexTrans.DOPause();
        indexTrans.gameObject.SetActive(false);

    }

    public void StartRotate()
    {
        indexTrans.gameObject.SetActive(true);
        indexTrans.DORestart();
    }

    public void PauseRotate()
    {
        indexTrans.gameObject.SetActive(false);
        indexTrans.DOPause();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
