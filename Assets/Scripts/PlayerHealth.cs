using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    void Start()
    {
        int nyawa = 100;
        int armor = 75;

        int[] scores = new int[5] { 100, 90, 85, 70, 60 };

        while (nyawa > 0)
        {
            Debug.Log("Health: " + nyawa);

            if (nyawa > 50)
            {
                Debug.Log("Pemain Sehat");
            }
            else if (nyawa >= 20 && nyawa <= 50)
            {
                Debug.Log("Pemain Perlu Berhati-hati");
            }
            else
            {
                Debug.Log("Pemain dalam Bahaya");
            }
            nyawa -= 10;
        }

        if (armor > 30 && nyawa > 50)
        {
            Debug.Log("Pemain Siap Bertarung");
        }
        else
        {
            Debug.Log("Pemain Perlu Bersiap");
        }

        int totalScore = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            totalScore += scores[i];
        }
        float rataRata = (float)totalScore / scores.Length;
        Debug.Log("Rata-rata skor: " + rataRata);

        bool kualitasPlayer = false;
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > 80)
            {
                kualitasPlayer = true;
                break;
            }
        }

        if (kualitasPlayer)
        {
            Debug.Log("Pemain berkualitas tinggi");
        }
        else
        {
            Debug.Log("Pemain butuh latihan");
        }
    }
}
