using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    Tween tween;
    Sequence sequence;
    // Start is called before the first frame update
    void Start()
    {
        //tween = transform.DOMoveX(5, 2);
        //transform.DORotate(new Vector3(0, 0, 180), 0.3f);
        //transform.DOScale(new Vector3(2, 2, 2), 2);

        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 0.5f));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 0.3f));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2));

        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce).OnComplete(DeactivateObject);
        //transform.DOShakeRotation(200f, new Vector3(0, 0, 5), 10, 90);


        sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(5, 2f));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }


    void DeactivateObject()
    {
        gameObject.SetActive(false);
        Debug.Log("���� ����");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();
            //tween.Kill();
        }
    }
}
