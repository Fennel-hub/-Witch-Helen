using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // �����һ��
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject endingCanvas; // ��Ϸ����ʱ��ʾ��Canvas
    public Image[] endingImages; // ���ľ���ͼƬ
    private int currentEndingImageIndex = 0; // ��ǰ��ʾ�ľ���ͼƬ������

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            gameObject.SetActive(false);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void EndGame()
    {
        StartCoroutine(PlayEndingImages());
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator PlayEndingImages()
    {
        Debug.Log("Ending Canvas: " + endingCanvas);
        // ��ʾ��Ϸ����ʱ��Canvas
        endingCanvas.SetActive(true);

        // ������ʾÿ��ͼƬ���ȴ���ҵ��������������ʾ��һ��
        for (currentEndingImageIndex = 0; currentEndingImageIndex < endingImages.Length; currentEndingImageIndex++)
        {
            endingImages[currentEndingImageIndex].enabled = true;
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            endingImages[currentEndingImageIndex].enabled = false;
        }

        // ��ʾ�����е�ͼƬ��������Ϸ
        RestartGame();
    }
}
