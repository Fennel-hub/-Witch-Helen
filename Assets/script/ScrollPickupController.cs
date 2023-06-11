using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrollPickupController : MonoBehaviour
{
    private bool playerNearby = false;
    public GameObject canvas;
    public Image[] images;
    private int currentImageIndex = 0;
    public int C = 0;
    public static int scrollsPickedUp = 0;
    public Text booksText;
   // public Image[] endingImages; // ���ľ���ͼƬ
    private int currentEndingImageIndex = 0; // ��ǰ��ʾ�ľ���ͼƬ������
   // public GameObject endingCanvas; // ��Ϸ����ʱ��ʾ��Canvas

    private void Start()
    {
        booksText.text = "0";
        scrollsPickedUp = 0;
        //��ʼʱ������Canvas
        canvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerNearby = true;
            collision.GetComponent<PlayerMovement>().EnablePickUp();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerNearby = false;
            collision.GetComponent<PlayerMovement>().DisablePickUp();
        }
    }

    private void Update()
    {
        C = GameObject.Find("Player").gameObject.GetComponent<ChannelScript>().C;

        if (playerNearby && (Input.GetKeyDown(KeyCode.Space) || C == 1))
        {
            //���ؾ������
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            // �����Ѿ�ʰȡ�ľ�������
            scrollsPickedUp++;
            // ��ʾCanvas�����ŵ�һ��ͼƬ
            canvas.SetActive(true);
            ShowImage(0);
        }

        // �������������������Canvas�Ǽ����
        if (Input.GetMouseButtonDown(0) && canvas.activeSelf)
        {
            currentImageIndex++;
            // ������и����ͼƬ
            if (currentImageIndex < images.Length)
            {
                // ��ʾ��һ��ͼƬ
                ShowImage(currentImageIndex);
            }
            else
            {
                // û�и����ͼƬ������Canvas
                canvas.SetActive(false);
                // ����currentImageIndex�������´ιۿ�
                currentImageIndex = 0;
            }
        }

        // ����Ƿ��Ѿ�ʰȡ�����еľ���
        if (scrollsPickedUp >= 7)
        {
            // ����Ѿ�ʰȡ�����еľ��ᣬ������Ϸ
            GameManager.instance.EndGame();
        }

        booksText.text = scrollsPickedUp.ToString();  //����BooksText����ʾ
    }

    void ShowImage(int index)
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].enabled = (i == index);
        }
    }
}
